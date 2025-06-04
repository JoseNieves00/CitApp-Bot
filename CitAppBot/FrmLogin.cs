using Telegram; //
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using System.Data.SqlClient;
using Npgsql;
using BLL;
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
        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
