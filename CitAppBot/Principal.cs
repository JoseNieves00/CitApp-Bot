using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CitAppBot
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        // Campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        

        // Colores
        private Color primaryColor = Color.FromArgb(0, 120, 100);
        private Color secondColor = Color.FromArgb(0, 100, 120);
        private Color thirdColor = Color.FromArgb(0, 130, 110);
        private Color fourthColor = Color.FromArgb(0, 110, 130);
        private Color fifthColor = Color.FromArgb(0, 140, 120);
        private Color sixthColor = Color.FromArgb(0, 90, 110);

        // Métodos
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconPictureChild.IconChar = currentBtn.IconChar;

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 128, 128);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void ConfigurarBoton(IconButton boton, string texto, IconChar icono, EventHandler eventoClick)
        {
            boton.Dock = DockStyle.Top;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Size = new Size(220, 60);
            boton.Text = texto;
            boton.IconChar = icono;
            boton.IconColor = Color.White;
            boton.IconFont = IconFont.Auto;
            boton.IconSize = 32;
            boton.ImageAlign = ContentAlignment.MiddleLeft;
            boton.TextAlign = ContentAlignment.MiddleLeft;
            boton.TextImageRelation = TextImageRelation.ImageBeforeText;
            boton.Padding = new Padding(10, 0, 0, 0);
            boton.ForeColor = Color.White;
            boton.BackColor = Color.FromArgb(20, 50, 60);
            boton.Click += eventoClick;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconPictureChild.IconChar = IconChar.Home;
            TituloHijo.Text = "Inicio";
        }

        // Eventos
        private void FrmPrincipal_Load(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void IBmedicos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, primaryColor);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, primaryColor);
        }

        private void IBcitas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, primaryColor);
        }

        private void IBpacientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, secondColor);
        }

        private void IBgestion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, thirdColor);
        }

        private void IBagregarmedico_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, fourthColor);
        }

        private void IP_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void iconPictureChild_Click(object sender, EventArgs e)
        {

        }

        private void TituloHijo_Click(object sender, EventArgs e)
        {

        }
    }
}
