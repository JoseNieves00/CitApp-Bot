namespace CitAppBot
{
    partial class FrmAgregarPaciente
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
            panel1 = new Panel();
            panel2 = new Panel();
            IBsalir = new FontAwesome.Sharp.IconButton();
            IBlimpiar = new FontAwesome.Sharp.IconButton();
            IBregistrar = new FontAwesome.Sharp.IconButton();
            textBoxCedula = new TextBox();
            lblCedula = new Label();
            textBoxNombre = new TextBox();
            lblNombre = new Label();
            textBoxIDpaciente = new TextBox();
            lbl_IDpaciente = new Label();
            textBoxCorreo = new TextBox();
            lblCorreo = new Label();
            textBoxtelefono = new TextBox();
            lblTelefono = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 695);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(textBoxtelefono);
            panel2.Controls.Add(lblTelefono);
            panel2.Controls.Add(textBoxCorreo);
            panel2.Controls.Add(lblCorreo);
            panel2.Controls.Add(IBsalir);
            panel2.Controls.Add(IBlimpiar);
            panel2.Controls.Add(IBregistrar);
            panel2.Controls.Add(textBoxCedula);
            panel2.Controls.Add(lblCedula);
            panel2.Controls.Add(textBoxNombre);
            panel2.Controls.Add(lblNombre);
            panel2.Controls.Add(textBoxIDpaciente);
            panel2.Controls.Add(lbl_IDpaciente);
            panel2.Location = new Point(62, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 601);
            panel2.TabIndex = 2;
            // 
            // IBsalir
            // 
            IBsalir.BackColor = Color.FromArgb(255, 128, 128);
            IBsalir.IconChar = FontAwesome.Sharp.IconChar.None;
            IBsalir.IconColor = Color.Black;
            IBsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBsalir.Location = new Point(138, 489);
            IBsalir.Name = "IBsalir";
            IBsalir.Size = new Size(140, 47);
            IBsalir.TabIndex = 12;
            IBsalir.Text = "Salir";
            IBsalir.UseVisualStyleBackColor = false;
            IBsalir.Click += IBsalir_Click;
            // 
            // IBlimpiar
            // 
            IBlimpiar.BackColor = Color.Silver;
            IBlimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            IBlimpiar.IconColor = Color.Black;
            IBlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBlimpiar.Location = new Point(220, 418);
            IBlimpiar.Name = "IBlimpiar";
            IBlimpiar.Size = new Size(140, 47);
            IBlimpiar.TabIndex = 11;
            IBlimpiar.Text = "Limpiar";
            IBlimpiar.UseVisualStyleBackColor = false;
            IBlimpiar.Click += IBlimpiar_Click;
            // 
            // IBregistrar
            // 
            IBregistrar.BackColor = Color.FromArgb(128, 255, 128);
            IBregistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            IBregistrar.IconColor = Color.Black;
            IBregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBregistrar.Location = new Point(37, 418);
            IBregistrar.Name = "IBregistrar";
            IBregistrar.Size = new Size(140, 47);
            IBregistrar.TabIndex = 10;
            IBregistrar.Text = "Registrar";
            IBregistrar.UseVisualStyleBackColor = false;
            IBregistrar.Click += IBregistrar_Click;
            // 
            // textBoxCedula
            // 
            textBoxCedula.Location = new Point(181, 190);
            textBoxCedula.Name = "textBoxCedula";
            textBoxCedula.Size = new Size(198, 27);
            textBoxCedula.TabIndex = 7;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(41, 193);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(58, 20);
            lblCedula.TabIndex = 6;
            lblCedula.Text = "Cedula:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(181, 124);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(198, 27);
            textBoxNombre.TabIndex = 5;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(41, 127);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            lblNombre.Click += lblNombre_Click;
            // 
            // textBoxIDpaciente
            // 
            textBoxIDpaciente.Location = new Point(181, 61);
            textBoxIDpaciente.Name = "textBoxIDpaciente";
            textBoxIDpaciente.Size = new Size(198, 27);
            textBoxIDpaciente.TabIndex = 3;
            textBoxIDpaciente.TextChanged += textBoxIDpaciente_TextChanged;
            // 
            // lbl_IDpaciente
            // 
            lbl_IDpaciente.AutoSize = true;
            lbl_IDpaciente.Location = new Point(41, 64);
            lbl_IDpaciente.Name = "lbl_IDpaciente";
            lbl_IDpaciente.Size = new Size(86, 20);
            lbl_IDpaciente.TabIndex = 2;
            lbl_IDpaciente.Text = "ID Paciente:";
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(181, 254);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(198, 27);
            textBoxCorreo.TabIndex = 14;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(41, 257);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(57, 20);
            lblCorreo.TabIndex = 13;
            lblCorreo.Text = "Correo:";
            // 
            // textBoxtelefono
            // 
            textBoxtelefono.Location = new Point(181, 318);
            textBoxtelefono.Name = "textBoxtelefono";
            textBoxtelefono.Size = new Size(198, 27);
            textBoxtelefono.TabIndex = 16;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(41, 321);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 15;
            lblTelefono.Text = "Telefono:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 23);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 17;
            label1.Text = "Agregar Paciente";
            // 
            // FrmAgregarPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 695);
            Controls.Add(panel1);
            Name = "FrmAgregarPaciente";
            Text = "FrmAgregarPaciente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton IBsalir;
        private FontAwesome.Sharp.IconButton IBlimpiar;
        private FontAwesome.Sharp.IconButton IBregistrar;
        private TextBox textBoxCedula;
        private Label lblCedula;
        private TextBox textBoxNombre;
        private Label lblNombre;
        private TextBox textBoxIDpaciente;
        private Label lbl_IDpaciente;
        private Label label1;
        private TextBox textBoxtelefono;
        private Label lblTelefono;
        private TextBox textBoxCorreo;
        private Label lblCorreo;
    }
}