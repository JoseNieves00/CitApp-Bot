using Telegram; //
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using System.Data.SqlClient;
using Npgsql;
using BLL;

namespace CitAppBot
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        TelegramBotClient BotClient;

        private UsuarioBLL adminBLL = new UsuarioBLL();

        private void Form1_Load(object sender, EventArgs e)
        {
            BotClient = new TelegramBotClient("7698032170:AAH9X71n_lxRv2QNjYvpki3V6ctOtUBKfJI");
            StartReceive();

        }

        public async Task StartReceive()
        {
            var token = new CancellationTokenSource();
            var cancelToken = token.Token;
            var ReOpt = new ReceiverOptions { AllowedUpdates = { } };
            await BotClient.ReceiveAsync(OnMessage, ErrorMessage, ReOpt, cancelToken);
        }

        public async Task OnMessage(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Message is Telegram.Bot.Types.Message message)
            {
                var inLineKeyboard = new Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup(new[]
                {
                   new []{
                    Telegram.Bot.Types.ReplyMarkups.InlineKeyboardButton.WithCallbackData("Salchipapa1"),
                    Telegram.Bot.Types.ReplyMarkups.InlineKeyboardButton.WithCallbackData("Salchipapa2"),
                   },
                   new []{
                    Telegram.Bot.Types.ReplyMarkups.InlineKeyboardButton.WithCallbackData("Salchipapa3"),
                   }

               });

                await BotClient.SendTextMessageAsync(
                        chatId: message.Chat.Id,
                        text: "¿ Que salchipapa deseas ?",
                        replyMarkup: inLineKeyboard,
                        cancellationToken: cancellationToken
                    );
            }

            if (update.CallbackQuery != null)
            {
                var callbackQuery = update.CallbackQuery;
                await BotClient.SendTextMessageAsync(
                        chatId: callbackQuery.Message.Chat.Id,
                        text: $"Tu salchipapa elegida es: {callbackQuery.Data}",
                        cancellationToken: cancellationToken
                    );
            }
        }

        public async Task ErrorMessage(ITelegramBotClient botClient, Exception e, CancellationToken cancellationToken)
        {
            if (e is ApiRequestException requestException)
            {
                await BotClient.SendTextMessageAsync("", e.Message.ToString());

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text.Trim();
            string contrasena = txtPassword.Text.Trim();

            bool acceso = adminBLL.Login(usuario, contrasena);

            if (acceso)
            {
                MessageBox.Show("Bienvenido");
                FrmPrincipal frm = new FrmPrincipal();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
