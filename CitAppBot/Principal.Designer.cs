
namespace CitAppBot
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            IBagregarmedico = new FontAwesome.Sharp.IconButton();
            IBagregarpaciente = new FontAwesome.Sharp.IconButton();
            IBgestion = new FontAwesome.Sharp.IconButton();
            IBmedicos = new FontAwesome.Sharp.IconButton();
            IBpacientes = new FontAwesome.Sharp.IconButton();
            IBcitas = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            PanelTtl = new Panel();
            TituloHijo = new Label();
            iconPictureChild = new FontAwesome.Sharp.IconPictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelTtl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureChild).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 64, 64);
            panelMenu.Controls.Add(IBagregarmedico);
            panelMenu.Controls.Add(IBagregarpaciente);
            panelMenu.Controls.Add(IBgestion);
            panelMenu.Controls.Add(IBmedicos);
            panelMenu.Controls.Add(IBpacientes);
            panelMenu.Controls.Add(IBcitas);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 520);
            panelMenu.TabIndex = 0;
            // 
            // IBagregarmedico
            // 
            IBagregarmedico.BackColor = Color.Teal;
            IBagregarmedico.Dock = DockStyle.Top;
            IBagregarmedico.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            IBagregarmedico.IconColor = Color.Black;
            IBagregarmedico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBagregarmedico.IconSize = 40;
            IBagregarmedico.ImageAlign = ContentAlignment.MiddleLeft;
            IBagregarmedico.Location = new Point(0, 425);
            IBagregarmedico.Name = "IBagregarmedico";
            IBagregarmedico.Padding = new Padding(10, 0, 20, 0);
            IBagregarmedico.Size = new Size(220, 60);
            IBagregarmedico.TabIndex = 6;
            IBagregarmedico.Text = "Agregar médico";
            IBagregarmedico.TextAlign = ContentAlignment.MiddleLeft;
            IBagregarmedico.TextImageRelation = TextImageRelation.ImageBeforeText;
            IBagregarmedico.UseVisualStyleBackColor = false;
            IBagregarmedico.Click += IBagregarmedico_Click;
            // 
            // IBagregarpaciente
            // 
            IBagregarpaciente.BackColor = Color.Teal;
            IBagregarpaciente.Dock = DockStyle.Top;
            IBagregarpaciente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            IBagregarpaciente.IconColor = Color.Black;
            IBagregarpaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBagregarpaciente.IconSize = 40;
            IBagregarpaciente.ImageAlign = ContentAlignment.MiddleLeft;
            IBagregarpaciente.Location = new Point(0, 365);
            IBagregarpaciente.Name = "IBagregarpaciente";
            IBagregarpaciente.Padding = new Padding(10, 0, 20, 0);
            IBagregarpaciente.Size = new Size(220, 60);
            IBagregarpaciente.TabIndex = 5;
            IBagregarpaciente.Text = "Agregar paciente";
            IBagregarpaciente.TextAlign = ContentAlignment.MiddleLeft;
            IBagregarpaciente.TextImageRelation = TextImageRelation.ImageBeforeText;
            IBagregarpaciente.UseVisualStyleBackColor = false;
            IBagregarpaciente.Click += iconButton4_Click;
            // 
            // IBgestion
            // 
            IBgestion.BackColor = Color.Teal;
            IBgestion.Dock = DockStyle.Top;
            IBgestion.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            IBgestion.IconColor = Color.Black;
            IBgestion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBgestion.IconSize = 40;
            IBgestion.ImageAlign = ContentAlignment.MiddleLeft;
            IBgestion.Location = new Point(0, 305);
            IBgestion.Name = "IBgestion";
            IBgestion.Padding = new Padding(10, 0, 20, 0);
            IBgestion.Size = new Size(220, 60);
            IBgestion.TabIndex = 4;
            IBgestion.Text = "Gestión";
            IBgestion.TextAlign = ContentAlignment.MiddleLeft;
            IBgestion.TextImageRelation = TextImageRelation.ImageBeforeText;
            IBgestion.UseVisualStyleBackColor = false;
            IBgestion.Click += IBgestion_Click;
            // 
            // IBmedicos
            // 
            IBmedicos.BackColor = Color.Teal;
            IBmedicos.Dock = DockStyle.Top;
            IBmedicos.IconChar = FontAwesome.Sharp.IconChar.UserDoctor;
            IBmedicos.IconColor = Color.Black;
            IBmedicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBmedicos.IconSize = 40;
            IBmedicos.ImageAlign = ContentAlignment.MiddleLeft;
            IBmedicos.Location = new Point(0, 245);
            IBmedicos.Name = "IBmedicos";
            IBmedicos.Padding = new Padding(10, 0, 20, 0);
            IBmedicos.Size = new Size(220, 60);
            IBmedicos.TabIndex = 3;
            IBmedicos.Text = "Médicos";
            IBmedicos.TextAlign = ContentAlignment.MiddleLeft;
            IBmedicos.TextImageRelation = TextImageRelation.ImageBeforeText;
            IBmedicos.UseVisualStyleBackColor = false;
            IBmedicos.Click += IBmedicos_Click;
            // 
            // IBpacientes
            // 
            IBpacientes.BackColor = Color.Teal;
            IBpacientes.Dock = DockStyle.Top;
            IBpacientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            IBpacientes.IconColor = Color.Black;
            IBpacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBpacientes.IconSize = 40;
            IBpacientes.ImageAlign = ContentAlignment.MiddleLeft;
            IBpacientes.Location = new Point(0, 185);
            IBpacientes.Name = "IBpacientes";
            IBpacientes.Padding = new Padding(10, 0, 20, 0);
            IBpacientes.Size = new Size(220, 60);
            IBpacientes.TabIndex = 2;
            IBpacientes.Text = "Pacientes";
            IBpacientes.TextAlign = ContentAlignment.MiddleLeft;
            IBpacientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            IBpacientes.UseVisualStyleBackColor = false;
            IBpacientes.Click += IBpacientes_Click;
            // 
            // IBcitas
            // 
            IBcitas.BackColor = Color.Teal;
            IBcitas.Dock = DockStyle.Top;
            IBcitas.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            IBcitas.IconColor = Color.Black;
            IBcitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBcitas.IconSize = 40;
            IBcitas.ImageAlign = ContentAlignment.MiddleLeft;
            IBcitas.Location = new Point(0, 125);
            IBcitas.Name = "IBcitas";
            IBcitas.Padding = new Padding(10, 0, 20, 0);
            IBcitas.Size = new Size(220, 60);
            IBcitas.TabIndex = 1;
            IBcitas.Text = "Citas";
            IBcitas.TextAlign = ContentAlignment.MiddleLeft;
            IBcitas.TextImageRelation = TextImageRelation.ImageBeforeText;
            IBcitas.UseVisualStyleBackColor = false;
            IBcitas.Click += IBcitas_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(0, 64, 64);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(10, 0, 20, 0);
            panelLogo.Size = new Size(220, 125);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_05_22_114858_removebg_preview;
            pictureBox1.Location = new Point(15, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // PanelTtl
            // 
            PanelTtl.BackColor = Color.FromArgb(0, 64, 64);
            PanelTtl.Controls.Add(TituloHijo);
            PanelTtl.Controls.Add(iconPictureChild);
            PanelTtl.Dock = DockStyle.Top;
            PanelTtl.Location = new Point(220, 0);
            PanelTtl.Name = "PanelTtl";
            PanelTtl.Size = new Size(833, 80);
            PanelTtl.TabIndex = 1;
            // 
            // TituloHijo
            // 
            TituloHijo.AutoSize = true;
            TituloHijo.Location = new Point(67, 27);
            TituloHijo.Name = "TituloHijo";
            TituloHijo.Size = new Size(50, 20);
            TituloHijo.TabIndex = 1;
            TituloHijo.Text = "label1";
            TituloHijo.Click += TituloHijo_Click;
            // 
            // iconPictureChild
            // 
            iconPictureChild.BackColor = Color.FromArgb(0, 64, 64);
            iconPictureChild.ForeColor = SystemColors.ControlText;
            iconPictureChild.IconChar = FontAwesome.Sharp.IconChar.House;
            iconPictureChild.IconColor = SystemColors.ControlText;
            iconPictureChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureChild.IconSize = 40;
            iconPictureChild.Location = new Point(21, 18);
            iconPictureChild.Name = "iconPictureChild";
            iconPictureChild.Size = new Size(40, 40);
            iconPictureChild.TabIndex = 0;
            iconPictureChild.TabStop = false;
            iconPictureChild.Click += iconPictureChild_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 520);
            Controls.Add(PanelTtl);
            Controls.Add(panelMenu);
            Name = "FrmPrincipal";
            Text = "Principal";
            Load += FrmPrincipal_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelTtl.ResumeLayout(false);
            PanelTtl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureChild).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton IBcitas;
        private FontAwesome.Sharp.IconButton IBagregarpaciente;
        private FontAwesome.Sharp.IconButton IBgestion;
        private FontAwesome.Sharp.IconButton IBmedicos;
        private FontAwesome.Sharp.IconButton IBpacientes;
        private FontAwesome.Sharp.IconButton IBagregarmedico;
        private PictureBox pictureBox1;
        private Panel PanelTtl;
        private FontAwesome.Sharp.IconPictureBox iconPictureChild;
        private Label TituloHijo;
    }
}


//using FontAwesome.Sharp;

//namespace CitAppBot
//{
//    partial class FrmPrincipal
//    {
//        private System.ComponentModel.IContainer components = null;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        private void InitializeComponent()
//        {
//            panelMenu = new Panel();
//            IBagregarmedico = new FontAwesome.Sharp.IconButton();
//            IBagregarpaciente = new FontAwesome.Sharp.IconButton();
//            IBgestion = new FontAwesome.Sharp.IconButton();
//            IBmedicos = new FontAwesome.Sharp.IconButton();
//            IBpacientes = new FontAwesome.Sharp.IconButton();
//            IBcitas = new FontAwesome.Sharp.IconButton();
//            panelLogo = new Panel();
//            pictureBox1 = new PictureBox();
//            PanelTtl = new Panel();
//            IP = new FontAwesome.Sharp.IconPictureBox();
//            panelMenu.SuspendLayout();
//            panelLogo.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
//            PanelTtl.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)IP).BeginInit();
//            SuspendLayout();

//            // panelMenu
//            panelMenu.BackColor = Color.FromArgb(10, 30, 40);
//            panelMenu.Controls.Add(IBagregarmedico);
//            panelMenu.Controls.Add(IBagregarpaciente);
//            panelMenu.Controls.Add(IBgestion);
//            panelMenu.Controls.Add(IBmedicos);
//            panelMenu.Controls.Add(IBpacientes);
//            panelMenu.Controls.Add(IBcitas);
//            panelMenu.Controls.Add(panelLogo);
//            panelMenu.Dock = DockStyle.Left;
//            panelMenu.Location = new Point(0, 0);
//            panelMenu.Name = "panelMenu";
//            panelMenu.Size = new Size(220, 671);
//            panelMenu.TabIndex = 0;

//            // Configuración general para botones
//              void ConfigurarBoton(IconButton boton, string texto, IconChar icono, EventHandler eventoClick)
//            {
//                boton.Dock = DockStyle.Top;
//                boton.FlatStyle = FlatStyle.Flat;
//                boton.FlatAppearance.BorderSize = 0;
//                boton.Size = new Size(220, 60);
//                boton.Text = texto;
//                boton.IconChar = icono;
//                boton.IconColor = Color.White;
//                boton.IconFont = FontAwesome.Sharp.IconFont.Auto;
//                boton.IconSize = 32;
//                boton.ImageAlign = ContentAlignment.MiddleLeft;
//                boton.TextAlign = ContentAlignment.MiddleLeft;
//                boton.TextImageRelation = TextImageRelation.ImageBeforeText;
//                boton.Padding = new Padding(10, 0, 0, 0);
//                boton.ForeColor = Color.White;
//                boton.BackColor = Color.FromArgb(20, 50, 60);
//                boton.Click += eventoClick;
//            }

//            ConfigurarBoton(IBagregarmedico, "Agregar médico", IconChar.Vcard, IBagregarmedico_Click);
//            ConfigurarBoton(IBagregarpaciente, "Agregar paciente", IconChar.UserPlus, iconButton4_Click);
//            ConfigurarBoton(IBgestion, "Gestión", IconChar.Sliders, IBgestion_Click);
//            ConfigurarBoton(IBmedicos, "Médicos", IconChar.UserDoctor, IBmedicos_Click);
//            ConfigurarBoton(IBpacientes, "Pacientes", IconChar.PeopleGroup, IBpacientes_Click);
//            ConfigurarBoton(IBcitas, "Citas", IconChar.Calendar, IBcitas_Click);

//            // panelLogo
//            panelLogo.BackColor = Color.FromArgb(10, 30, 40);
//            panelLogo.Controls.Add(pictureBox1);
//            panelLogo.Dock = DockStyle.Top;
//            panelLogo.Location = new Point(0, 0);
//            panelLogo.Name = "panelLogo";
//            panelLogo.Size = new Size(220, 125);
//            panelLogo.TabIndex = 0;
//            panelLogo.Paint += panel1_Paint;

//            // pictureBox1
//            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_05_22_114858_removebg_preview;
//            pictureBox1.Location = new Point(15, 18);
//            pictureBox1.Name = "pictureBox1";
//            pictureBox1.Size = new Size(169, 101);
//            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
//            pictureBox1.TabIndex = 0;
//            pictureBox1.TabStop = false;
//            pictureBox1.Click += pictureBox1_Click;

//            // PanelTtl
//            PanelTtl.BackColor = Color.FromArgb(0, 64, 64);
//            PanelTtl.Controls.Add(IP);
//            PanelTtl.Dock = DockStyle.Top;
//            PanelTtl.Location = new Point(220, 0);
//            PanelTtl.Name = "PanelTtl";
//            PanelTtl.Size = new Size(1106, 80);
//            PanelTtl.TabIndex = 1;

//            // FrmPrincipal
//            AutoScaleDimensions = new SizeF(8F, 20F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(1326, 671);
//            Controls.Add(PanelTtl);
//            Controls.Add(panelMenu);
//            Name = "FrmPrincipal";
//            Text = "Principal";
//            Load += FrmPrincipal_Load;
//            panelMenu.ResumeLayout(false);
//            panelLogo.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
//            PanelTtl.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)IP).EndInit();
//            ResumeLayout(false);
//        }



//        #endregion

//        private Panel panelMenu;
//        private Panel panelLogo;
//        private FontAwesome.Sharp.IconButton IBcitas;
//        private FontAwesome.Sharp.IconButton IBagregarpaciente;
//        private FontAwesome.Sharp.IconButton IBgestion;
//        private FontAwesome.Sharp.IconButton IBmedicos;
//        private FontAwesome.Sharp.IconButton IBpacientes;
//        private FontAwesome.Sharp.IconButton IBagregarmedico;
//        private PictureBox pictureBox1;
//        private Panel PanelTtl;
//        private FontAwesome.Sharp.IconPictureBox IP;
//    }
//}
