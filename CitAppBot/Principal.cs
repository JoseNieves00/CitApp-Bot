using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        //colores
        private Color primaryColor = Color.FromArgb(0, 150, 136);
        private Color secondColor = Color.FromArgb(7, 7, 7);
        private Color thirdColor = Color.FromArgb(0, 150, 136);
        private Color fourthColor = Color.FromArgb(0, 150, 136);
        private Color fifthColor = Color.FromArgb(0, 150, 136);
        private Color sixthColor = Color.FromArgb(0, 150, 136);
        private Color seventhColor = Color.FromArgb(0, 150, 136);



        //metodos
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
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }







        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

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
    }
}
