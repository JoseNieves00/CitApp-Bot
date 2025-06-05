using Telegram; // 
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using System.Data.SqlClient;
using Npgsql;
using BLL;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using System.Data;
using ENTITY;
using System.Globalization;

namespace CitAppBot
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        TelegramBotClient BotClient;

        // ========== EVENTOS Y LÓGICA DEL LOGIN ==========
        private void Form1_Load(object sender, EventArgs e)
        {
            BotClient = new TelegramBotClient("8059200833:AAEhtJgEEeJ9ol5hPHpc8VSiJsuqXGZTTcU");
            _ = StartReceive(); // Chatbot se inicia al cargar el form
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void limpiarCampos()
        {
            txtUser.Clear();
            txtPassword.Clear();
        }

        private void IniciarSesion()
        {
            string usuario = txtUser.Text.Trim();
            string clave = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Ingrese usuario y clave.");
                return;
            }

            DataTable dt = UsuarioBLL.ValidarLogin(usuario, clave);

            if (dt.Rows.Count > 0)
            {
                // Guardar sesión
                UsuarioSession.IdUsuario = Convert.ToInt32(dt.Rows[0]["idusuario"]);
                UsuarioSession.NombreUsuario = dt.Rows[0]["usuario"].ToString();
                UsuarioSession.IdRol = Convert.ToInt32(dt.Rows[0]["idrol"]);
                UsuarioSession.NombreRol = dt.Rows[0]["nombrerol"].ToString();
                UsuarioSession.CedulaPersona = dt.Rows[0]["cedulapersona"].ToString();

                // Abrir menú principal
                FrmPrincipal menu = new FrmPrincipal();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrecta.");
                limpiarCampos();
                txtUser.Focus();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        // ========== LÓGICA DEL CHATBOT DE TELEGRAM ==========

        private static readonly Dictionary<long, string> EstadoChat = new();
        private static readonly Dictionary<long, Cita> AgendaTemporal = new();
        private static readonly Dictionary<long, Paciente> PacientesPorChat = new();
        Cita cita = new Cita();
        Paciente paciente = new Paciente();
        Medico medico = new Medico(); 

        public async Task StartReceive()
        {
            var cts = new CancellationTokenSource();
            var options = new ReceiverOptions { AllowedUpdates = { } };
            BotClient.StartReceiving(HandleUpdateAsync, HandleErrorAsync, options, cts.Token);

            var me = await BotClient.GetMeAsync();
        }

        public async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            var chatId = update.Type switch
            {
                UpdateType.Message => update.Message.Chat.Id,
                UpdateType.CallbackQuery => update.CallbackQuery.Message.Chat.Id,
                _ => 0
            };

            if (update.Type == UpdateType.Message && update.Message.Type == MessageType.Text)
            {
                var userMessage = update.Message.Text.Trim().ToLower();

                if (!PacientesPorChat.ContainsKey(chatId) && !EstadoChat.ContainsKey(chatId))
                {
                    await BotClient.SendTextMessageAsync(chatId, "👋 ¡Hola! Bienvenido a CitApp.\nPor favor, ingresa tu número de cédula para comenzar:");
                    EstadoChat[chatId] = "esperando_cedula";
                    return;
                }

                if (EstadoChat.TryGetValue(chatId, out string estado))
                {
                    if (estado == "esperando_cedula")
                    {
                        string cedula = update.Message.Text.Trim();
                        var paciente = PacienteBLL.ObtenerPaciente(cedula);

                        if (paciente == null)
                        {
                            await BotClient.SendTextMessageAsync(chatId, "❌ Cédula no encontrada. Intenta nuevamente.");
                            return;
                        }

                        PacientesPorChat[chatId] = paciente;
                        AgendaTemporal[chatId] = new Cita { Paciente = paciente };
                        EstadoChat[chatId] = "menu_principal";

                        var inlineMenu = new InlineKeyboardMarkup(new[]
                        {
                    new[]
                    {
                        InlineKeyboardButton.WithCallbackData("📅 Consultar cita", "menu_consultar"),
                        InlineKeyboardButton.WithCallbackData("➕ Agendar cita", "menu_agendar")
                    }
                });

                        await BotClient.SendTextMessageAsync(chatId, $"¡Hola, {paciente.Nombre}!\n¿Qué deseas hacer?", replyMarkup: inlineMenu);
                        return;
                    }

                    if (estado == "preguntar_menu")
                    {
                        if (userMessage == "menu" || userMessage == "volver" || userMessage == "sí" || userMessage == "si")
                        {
                            EstadoChat.Remove(chatId);
                            var inlineMenu = new InlineKeyboardMarkup(new[]
                            {
                        new[]
                        {
                            InlineKeyboardButton.WithCallbackData("📅 Consultar cita", "menu_consultar"),
                            InlineKeyboardButton.WithCallbackData("➕ Agendar cita", "menu_agendar")
                        }
                    });

                            await BotClient.SendTextMessageAsync(chatId, "¿Qué deseas hacer ahora?", replyMarkup: inlineMenu);
                        }
                        else
                        {
                            await BotClient.SendTextMessageAsync(chatId, "Gracias por usar el sistema. ¡Hasta luego!");
                            EstadoChat.Remove(chatId);
                            PacientesPorChat.Remove(chatId);
                        }
                        return;
                    }

                    if (estado == "esperando_fecha")
                    {
                        if (DateTime.TryParseExact(update.Message.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var fecha))
                        {
                            if (AgendaTemporal.TryGetValue(chatId, out var cita))
                            {
                                cita.Fecha = fecha;
                                var horarios = CitaBLL.ObtenerHorariosDisponibles(cita.Medico, fecha);
                                if (horarios.Any())
                                {
                                    var opciones = horarios.Select(h =>
                                        new[] { InlineKeyboardButton.WithCallbackData(h.ToString(@"hh\:mm"), $"hora_{h}") }).ToList();

                                    EstadoChat[chatId] = "esperando_hora";
                                    await BotClient.SendTextMessageAsync(chatId, "🕐 Elige una hora disponible:", replyMarkup: new InlineKeyboardMarkup(opciones));
                                }
                                else
                                {
                                    await BotClient.SendTextMessageAsync(chatId, "⚠️ No hay horarios disponibles para esa fecha. Ingresa otra (dd/MM/yyyy):");
                                }
                            }
                        }
                        else
                        {
                            await BotClient.SendTextMessageAsync(chatId, "❌ Fecha inválida. Intenta con el formato dd/MM/yyyy.");
                        }
                        return;
                    }

                    if (estado == "esperando_confirmacion")
                    {
                        if (userMessage == "sí" || userMessage == "si" || userMessage == "confirmar")
                        {
                            if (AgendaTemporal.TryGetValue(chatId, out var citaFinal))
                            {
                                CitaBLL.AgendarCita(citaFinal);

                                await BotClient.SendTextMessageAsync(chatId, $"✅ Tu cita fue agendada con éxito:\n📅 Fecha: {citaFinal.Fecha:dd/MM/yyyy}\n🕓 Hora: {citaFinal.Hora}\n👨‍⚕️ Médico: {citaFinal.Medico?.Nombre}");

                                AgendaTemporal.Remove(chatId);
                                EstadoChat[chatId] = "preguntar_menu";
                                await EnviarPreguntaMenu(chatId);
                            }
                            else
                            {
                                await BotClient.SendTextMessageAsync(chatId, "❌ Ocurrió un error. No se pudo encontrar la cita a confirmar.");
                            }
                        }
                        else
                        {
                            await BotClient.SendTextMessageAsync(chatId, "❌ Cita cancelada. Puedes volver a intentarlo cuando desees.");
                            AgendaTemporal.Remove(chatId);
                            EstadoChat[chatId] = "preguntar_menu";
                            await EnviarPreguntaMenu(chatId);
                        }
                        return;
                    }
                }
            }


            else if (update.Type == UpdateType.CallbackQuery)
            {
                var callback = update.CallbackQuery;
                var data = callback.Data;
                var chatIdCb = callback.Message.Chat.Id;

                if (data == "menu_consultar")
                {
                    if (PacientesPorChat.TryGetValue(chatIdCb, out var paciente))
                    {
                        CitaBLL citaBLL = new CitaBLL();
                        List<Cita> citas = citaBLL.ObtenerCitasPorCedula(paciente.Cedula);

                        if (citas != null && citas.Any())
                        {
                            var citasOrdenadas = citas.OrderBy(c => c.Fecha).ThenBy(c => c.Hora).ToList();
                            string mensaje = "📋 Tus citas agendadas:\n";

                            foreach (var cita in citasOrdenadas)
                            {
                                mensaje += $"\n🧑‍⚕️ Médico: {cita.Medico?.Nombre ?? "No especificado"}" +
                                           $"\n📅 Fecha: {cita.Fecha:dd/MM/yyyy}" +
                                           $"\n🕓 Hora: {cita.Hora}\n";
                            }

                            await BotClient.SendTextMessageAsync(chatIdCb, mensaje);
                        }
                        else
                        {
                            await BotClient.SendTextMessageAsync(chatIdCb, "ℹ️ No tienes citas agendadas.");
                        }

                        EstadoChat[chatIdCb] = "preguntar_menu";
                        await EnviarPreguntaMenu(chatIdCb);
                    }

                    await BotClient.AnswerCallbackQueryAsync(callback.Id);
                }
                else if (data == "menu_agendar")
                {
                    var especialidades = EspecialidadBLL.ObtenerTodas();
                    var opciones = especialidades.Select(esp =>
                        new[] { InlineKeyboardButton.WithCallbackData(esp.Nombre, $"especialidad_{esp.Id}") }).ToList();

                    EstadoChat[chatIdCb] = "seleccionando_especialidad";

                    await BotClient.SendTextMessageAsync(
                        chatIdCb,
                        "🔍 Selecciona una especialidad:",
                        replyMarkup: new InlineKeyboardMarkup(opciones)
                    );
                    await BotClient.AnswerCallbackQueryAsync(callback.Id);
                }
                else if (data.StartsWith("especialidad_"))
                {
                    var especialidadId = long.Parse(data.Split('_')[1]);
                    var especialidadSeleccionada = EspecialidadBLL.ObtenerEspecialidadPorId(especialidadId);
                    var medicos = MedicoBLL.ObtenerPorEspecialidad(especialidadSeleccionada);

                    var inlineMedicos = new List<InlineKeyboardButton[]>();
                    foreach (var medico in medicos)
                    {
                        inlineMedicos.Add(new[]
                        {
                    InlineKeyboardButton.WithCallbackData($"Dr. {medico.Nombre}", $"medico_{medico.Cedula}")
                });
                    }

                    await BotClient.SendTextMessageAsync(
                        chatIdCb,
                        $"🩺 Especialidad seleccionada: {especialidadSeleccionada.Nombre}\nAhora selecciona un médico:",
                        replyMarkup: new InlineKeyboardMarkup(inlineMedicos)
                    );
                }
                else if (data.StartsWith("medico_"))
                {
                    string idMedico = data.Split('_')[1];
                    var medico = MedicoBLL.ObtenerMedico(idMedico);
                    if (medico == null)
                    {
                        await BotClient.SendTextMessageAsync(chatIdCb, "❌ Error: no se encontró el médico.");
                        return;
                    }

                    DateTime hoy = DateTime.Today;
                    int diasRestantes = DateTime.DaysInMonth(hoy.Year, hoy.Month) - hoy.Day + 1;

                    var inlineFechas = new List<InlineKeyboardButton[]>();
                    for (int i = 0; i < diasRestantes; i++)
                    {
                        DateTime fecha = hoy.AddDays(i);
                        string textoFecha = fecha.ToString("dd/MM/yyyy");
                        string callbackData = $"fecha_{idMedico}_{fecha:yyyyMMdd}";

                        inlineFechas.Add(new[] { InlineKeyboardButton.WithCallbackData(textoFecha, callbackData) });
                    }

                    if (!AgendaTemporal.ContainsKey(chatIdCb))
                        AgendaTemporal[chatIdCb] = new Cita();

                    AgendaTemporal[chatIdCb].Medico = medico;

                    await BotClient.SendTextMessageAsync(
                        chatIdCb,
                        $"🧑‍⚕️ Médico seleccionado: {medico.Nombre}\nSelecciona una fecha:",
                        replyMarkup: new InlineKeyboardMarkup(inlineFechas)
                    );
                }
                else if (data.StartsWith("hora_"))
                {
                    var horaStr = data.Split('_')[1];
                    if (AgendaTemporal.TryGetValue(chatIdCb, out var cita))
                    {
                        if (TimeSpan.TryParse(horaStr, out var hora))
                        {
                            cita.Hora = hora;

                            EstadoChat[chatIdCb] = "esperando_confirmacion";

                            var confirmButtons = new InlineKeyboardMarkup(new[]
                            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("✅ Confirmar", "confirmar_cita"),
                    InlineKeyboardButton.WithCallbackData("❌ Cancelar", "cancelar_cita")
                }
            });

                            await BotClient.SendTextMessageAsync(chatIdCb,
                                $"📋 Confirma tu cita:\n👨‍⚕️ Médico: {cita.Medico?.Nombre}\n📅 Fecha: {cita.Fecha:dd/MM/yyyy}\n🕓 Hora: {cita.Hora}\n\n¿Deseas confirmar?",
                                replyMarkup: confirmButtons
                            );
                        }
                    }
                }

                else if (data == "confirmar_cita")
                {
                    if (AgendaTemporal.TryGetValue(chatIdCb, out var citaConfirmada))
                    {
                        CitaBLL.AgendarCita(citaConfirmada);

                        await BotClient.SendTextMessageAsync(chatIdCb, $"✅ Tu cita fue agendada con éxito:\n📅 Fecha: {citaConfirmada.Fecha:dd/MM/yyyy}\n🕓 Hora: {citaConfirmada.Hora}\n👨‍⚕️ Médico: {citaConfirmada.Medico.Nombre}");

                        AgendaTemporal.Remove(chatIdCb);
                        EstadoChat[chatIdCb] = "preguntar_menu";
                        await EnviarPreguntaMenu(chatIdCb);
                    }
                   

                    await BotClient.AnswerCallbackQueryAsync(callback.Id);
                }
                else if (data == "cancelar_cita")
                {
                    AgendaTemporal.Remove(chatIdCb);
                    EstadoChat[chatIdCb] = "preguntar_menu";

                    await BotClient.SendTextMessageAsync(chatIdCb, "❌ Cita cancelada.");
                    await EnviarPreguntaMenu(chatIdCb);

                    await BotClient.AnswerCallbackQueryAsync(callback.Id);
                }


                else if (data.StartsWith("fecha_"))
                {
                    var parts = data.Split('_');
                    var fechaStr = parts[2];
                    if (DateTime.TryParseExact(fechaStr, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var fecha))
                    {
                        if (AgendaTemporal.TryGetValue(chatIdCb, out var cita))
                        {
                            cita.Fecha = fecha;

                            var horarios = CitaBLL.ObtenerHorariosDisponibles(cita.Medico, fecha);
                            var botones = horarios.Select(h =>
                                new[] { InlineKeyboardButton.WithCallbackData(h.ToString(@"hh\:mm"), $"hora_{h}") }).ToList();

                            EstadoChat[chatIdCb] = "esperando_hora";

                            await BotClient.SendTextMessageAsync(
                                chatIdCb,
                                $"📅 Fecha seleccionada: {fecha:dd/MM/yyyy}\nSelecciona una hora disponible:",
                                replyMarkup: new InlineKeyboardMarkup(botones)
                            );
                        }
                    }
                }


            }
        }

        // Método auxiliar para preguntar si quiere volver al menú o salir
        private async Task EnviarPreguntaMenu(long chatId)
        {
            var inlinePregunta = new InlineKeyboardMarkup(new[]
            {
        new[] { InlineKeyboardButton.WithCallbackData("Volver al menú", "volver_menu") }
    });

            await BotClient.SendTextMessageAsync(
                chatId: chatId,
                text: "¿Quieres volver al menú principal?",
                replyMarkup: inlinePregunta
            );
        }


        private Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            Console.WriteLine($"❌ Error en el bot: {exception}");
            return Task.CompletedTask;
        }
    }
}
