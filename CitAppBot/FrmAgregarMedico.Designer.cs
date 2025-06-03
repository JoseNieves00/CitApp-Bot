namespace CitAppBot
{
    partial class FrmAgregarMedico
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
            comboBoxEspecialidad = new ComboBox();
            lblEspecialidad = new Label();
            textBoxCedula = new TextBox();
            lblCedula = new Label();
            textBoxNombre = new TextBox();
            lblNombre = new Label();
            textBoxIDmedico = new TextBox();
            lbl_IDmedico = new Label();
            label1 = new Label();
            IBregistrar = new FontAwesome.Sharp.IconButton();
            IBlimpiar = new FontAwesome.Sharp.IconButton();
            IBsalir = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 603);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.Controls.Add(IBsalir);
            panel2.Controls.Add(IBlimpiar);
            panel2.Controls.Add(IBregistrar);
            panel2.Controls.Add(comboBoxEspecialidad);
            panel2.Controls.Add(lblEspecialidad);
            panel2.Controls.Add(textBoxCedula);
            panel2.Controls.Add(lblCedula);
            panel2.Controls.Add(textBoxNombre);
            panel2.Controls.Add(lblNombre);
            panel2.Controls.Add(textBoxIDmedico);
            panel2.Controls.Add(lbl_IDmedico);
            panel2.Location = new Point(28, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 446);
            panel2.TabIndex = 1;
            // 
            // comboBoxEspecialidad
            // 
            comboBoxEspecialidad.FormattingEnabled = true;
            comboBoxEspecialidad.Location = new Point(181, 238);
            comboBoxEspecialidad.Name = "comboBoxEspecialidad";
            comboBoxEspecialidad.Size = new Size(198, 28);
            comboBoxEspecialidad.TabIndex = 9;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(41, 241);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(96, 20);
            lblEspecialidad.TabIndex = 8;
            lblEspecialidad.Text = "Especialidad:";
            // 
            // textBoxCedula
            // 
            textBoxCedula.Location = new Point(181, 184);
            textBoxCedula.Name = "textBoxCedula";
            textBoxCedula.Size = new Size(198, 27);
            textBoxCedula.TabIndex = 7;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(41, 187);
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
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(41, 127);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // textBoxIDmedico
            // 
            textBoxIDmedico.Location = new Point(181, 61);
            textBoxIDmedico.Name = "textBoxIDmedico";
            textBoxIDmedico.Size = new Size(198, 27);
            textBoxIDmedico.TabIndex = 3;
            // 
            // lbl_IDmedico
            // 
            lbl_IDmedico.AutoSize = true;
            lbl_IDmedico.Location = new Point(41, 64);
            lbl_IDmedico.Name = "lbl_IDmedico";
            lbl_IDmedico.Size = new Size(81, 20);
            lbl_IDmedico.TabIndex = 2;
            lbl_IDmedico.Text = "ID Médico:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 61);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Agregar Médico";
            label1.Click += label1_Click;
            // 
            // IBregistrar
            // 
            IBregistrar.BackColor = Color.FromArgb(128, 255, 128);
            IBregistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            IBregistrar.IconColor = Color.Black;
            IBregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBregistrar.Location = new Point(28, 299);
            IBregistrar.Name = "IBregistrar";
            IBregistrar.Size = new Size(140, 47);
            IBregistrar.TabIndex = 10;
            IBregistrar.Text = "Registrar";
            IBregistrar.UseVisualStyleBackColor = false;
            // 
            // IBlimpiar
            // 
            IBlimpiar.BackColor = Color.Silver;
            IBlimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            IBlimpiar.IconColor = Color.Black;
            IBlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBlimpiar.Location = new Point(211, 299);
            IBlimpiar.Name = "IBlimpiar";
            IBlimpiar.Size = new Size(140, 47);
            IBlimpiar.TabIndex = 11;
            IBlimpiar.Text = "Limpiar";
            IBlimpiar.UseVisualStyleBackColor = false;
            // 
            // IBsalir
            // 
            IBsalir.BackColor = Color.FromArgb(255, 128, 128);
            IBsalir.IconChar = FontAwesome.Sharp.IconChar.None;
            IBsalir.IconColor = Color.Black;
            IBsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBsalir.Location = new Point(129, 370);
            IBsalir.Name = "IBsalir";
            IBsalir.Size = new Size(140, 47);
            IBsalir.TabIndex = 12;
            IBsalir.Text = "Salir";
            IBsalir.UseVisualStyleBackColor = false;
            // 
            // FrmAgregarMedico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 603);
            Controls.Add(panel1);
            Name = "FrmAgregarMedico";
            Text = "FrmAgregarMedico";
            Load += FrmAgregarMedico_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label lblEspecialidad;
        private TextBox textBoxCedula;
        private Label lblCedula;
        private TextBox textBoxNombre;
        private Label lblNombre;
        private TextBox textBoxIDmedico;
        private Label lbl_IDmedico;
        private ComboBox comboBoxEspecialidad;
        private FontAwesome.Sharp.IconButton IBlimpiar;
        private FontAwesome.Sharp.IconButton IBregistrar;
        private FontAwesome.Sharp.IconButton IBsalir;
    }
}