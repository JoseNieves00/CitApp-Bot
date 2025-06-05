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
            StartReceive(); // Chatbot se inicia al cargar el form
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

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
                // Guardar sesi�n
                UsuarioSession.IdUsuario = Convert.ToInt32(dt.Rows[0]["idusuario"]);
                UsuarioSession.NombreUsuario = dt.Rows[0]["usuario"].ToString();
                UsuarioSession.IdRol = Convert.ToInt32(dt.Rows[0]["idrol"]);
                UsuarioSession.NombreRol = dt.Rows[0]["nombrerol"].ToString();
                UsuarioSession.CedulaPersona = dt.Rows[0]["cedulapersona"].ToString();

                // Abrir men� principal
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
        private static readonly Dictionary<long, string> TemporalDatos = new(); // puedes usarlo para guardar temporalmente valores

        public async Task StartReceive()
        {
            var token = new CancellationTokenSource();
            var cancelToken = token.Token;
            var ReOpt = new ReceiverOptions { AllowedUpdates = { } };
            await BotClient.ReceiveAsync(OnMessage, ErrorMessage, ReOpt, cancelToken);
        }

        public async Task OnMessage(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.CallbackQuery != null)
            {
                var chatId = update.CallbackQuery.Message.Chat.Id;
                var opcion = update.CallbackQuery.Data;

                switch (opcion)
                {
                    case "📅 Agendar una cita":
                        EstadoChat[chatId] = "Agendando_IDPaciente";
                        await BotClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "🔢 Por favor, escribe tu *ID de paciente* para comenzar a agendar la cita.",
                            parseMode: ParseMode.Markdown,
                            cancellationToken: cancellationToken
                        );
                        break;

                    case "✏️ Modificar una cita":
                        EstadoChat[chatId] = "Modificando_IDCita";
                        await BotClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "🔁 Para modificar una cita, escribe el *ID de la cita* que deseas actualizar.",
                            parseMode: ParseMode.Markdown,
                            cancellationToken: cancellationToken
                        );
                        break;

                    case "❌ Cancelar una cita":
                        EstadoChat[chatId] = "Cancelando_IDCita";
                        await BotClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: "🗑 Escribe el *ID de la cita* que deseas cancelar.",
                            parseMode: ParseMode.Markdown,
                            cancellationToken: cancellationToken
                        );
                        break;
                }

                return; // No sigas con el mensaje principal si es un callback
            }

            if (update.Message is Telegram.Bot.Types.Message message && message.Text != null)
            {
                var chatId = message.Chat.Id;
                var texto = message.Text.Trim();

                if (!EstadoChat.ContainsKey(chatId))
                {
                    // Mostrar menú inicial
                    var inLineKeyboard = new InlineKeyboardMarkup(new[]
                    {
                new []
                {
                    InlineKeyboardButton.WithCallbackData("📅 Agendar una cita"),
                    InlineKeyboardButton.WithCallbackData("✏️ Modificar una cita")
                },
                new []
                {
                    InlineKeyboardButton.WithCallbackData("❌ Cancelar una cita")
                }
            });

                    await BotClient.SendTextMessageAsync(
                        chatId: chatId,
                        text: "Hola 👋\n\n¿Cómo puedo ayudarte hoy? Selecciona una opción:",
                        replyMarkup: inLineKeyboard,
                        cancellationToken: cancellationToken
                    );
                    return;
                }

                var estadoActual = EstadoChat[chatId];

                switch (estadoActual)
                {
                    case "Agendando_IDPaciente":
                        TemporalDatos[chatId] = $"Paciente:{texto}";
                        EstadoChat[chatId] = "Agendando_IDMedico";
                        await BotClient.SendTextMessageAsync(chatId, "🩺 Escribe el *ID del médico* que deseas.", parseMode: ParseMode.Markdown);
                        break;

                    case "Agendando_IDMedico":
                        TemporalDatos[chatId] += $"|Medico:{texto}";
                        EstadoChat[chatId] = "Agendando_Fecha";
                        await BotClient.SendTextMessageAsync(chatId, "📆 Escribe la *fecha* (formato YYYY-MM-DD) para tu cita:", parseMode: ParseMode.Markdown);
                        break;

                    case "Agendando_Fecha":
                        TemporalDatos[chatId] += $"|Fecha:{texto}";
                        EstadoChat[chatId] = "Agendando_Hora";
                        await BotClient.SendTextMessageAsync(chatId, "⏰ Escribe la *hora* (formato HH:mm) para tu cita:", parseMode: ParseMode.Markdown);
                        break;

                    case "Agendando_Hora":
                        TemporalDatos[chatId] += $"|Hora:{texto}";
                        EstadoChat.Remove(chatId); // finalizar flujo
                        await BotClient.SendTextMessageAsync(chatId, "✅ ¡Cita registrada! (En esta versión de prueba aún no se guarda en base de datos).");
                        break;

                    case "Modificando_IDCita":
                        TemporalDatos[chatId] = $"IDCita:{texto}";
                        EstadoChat[chatId] = "Modificando_Fecha";
                        await BotClient.SendTextMessageAsync(chatId, "📆 Escribe la *nueva fecha* (YYYY-MM-DD):", parseMode: ParseMode.Markdown);
                        break;

                    case "Modificando_Fecha":
                        TemporalDatos[chatId] += $"|Fecha:{texto}";
                        EstadoChat[chatId] = "Modificando_Hora";
                        await BotClient.SendTextMessageAsync(chatId, "⏰ Escribe la *nueva hora* (HH:mm):", parseMode: ParseMode.Markdown);
                        break;

                    case "Modificando_Hora":
                        TemporalDatos[chatId] += $"|Hora:{texto}";
                        EstadoChat.Remove(chatId); // finalizar flujo
                        await BotClient.SendTextMessageAsync(chatId, "✅ ¡Cita modificada! (Pendiente lógica de actualización en la base de datos).");
                        break;

                    case "Cancelando_IDCita":
                        EstadoChat.Remove(chatId);
                        await BotClient.SendTextMessageAsync(chatId, $"✅ Cita con ID `{texto}` ha sido *cancelada* (simulado).", parseMode: ParseMode.Markdown);
                        break;

                    default:
                        await BotClient.SendTextMessageAsync(chatId, "⚠️ No entendí tu mensaje. Por favor, selecciona una opción del menú.");
                        EstadoChat.Remove(chatId); // resetear para evitar bloqueos
                        break;
                }
            }
        }

        public async Task ErrorMessage(ITelegramBotClient botClient, Exception e, CancellationToken cancellationToken)
        {
            if (e is ApiRequestException requestException)
            {
                Console.WriteLine("Error de API: " + requestException.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
