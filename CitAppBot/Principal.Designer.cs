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
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ControlDarkDark;
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
            panelMenu.Size = new Size(220, 671);
            panelMenu.TabIndex = 0;
            // 
            // IBagregarmedico
            // 
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
            IBagregarmedico.UseVisualStyleBackColor = true;
            IBagregarmedico.Click += IBagregarmedico_Click;
            // 
            // IBagregarpaciente
            // 
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
            IBagregarpaciente.UseVisualStyleBackColor = true;
            IBagregarpaciente.Click += iconButton4_Click;
            // 
            // IBgestion
            // 
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
            IBgestion.UseVisualStyleBackColor = true;
            IBgestion.Click += IBgestion_Click;
            // 
            // IBmedicos
            // 
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
            IBmedicos.UseVisualStyleBackColor = true;
            IBmedicos.Click += IBmedicos_Click;
            // 
            // IBpacientes
            // 
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
            IBpacientes.UseVisualStyleBackColor = true;
            IBpacientes.Click += IBpacientes_Click;
            // 
            // IBcitas
            // 
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
            IBcitas.UseVisualStyleBackColor = true;
            IBcitas.Click += IBcitas_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(10, 0, 20, 0);
            panelLogo.Size = new Size(220, 125);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += panel1_Paint;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 671);
            Controls.Add(panelMenu);
            Name = "FrmPrincipal";
            Text = "Principal";
            Load += FrmPrincipal_Load;
            panelMenu.ResumeLayout(false);
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
    }
}