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
            IBsalir = new FontAwesome.Sharp.IconButton();
            IBlimpiar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            cmbEspecialidad = new ComboBox();
            lblEspecialidad = new Label();
            txtCedula = new TextBox();
            lblCedula = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            label1 = new Label();
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
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 904);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.Controls.Add(IBsalir);
            panel2.Controls.Add(IBlimpiar);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(cmbEspecialidad);
            panel2.Controls.Add(lblEspecialidad);
            panel2.Controls.Add(txtCedula);
            panel2.Controls.Add(lblCedula);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(lblNombre);
            panel2.Location = new Point(42, 146);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(642, 669);
            panel2.TabIndex = 1;
            // 
            // IBsalir
            // 
            IBsalir.BackColor = Color.FromArgb(255, 128, 128);
            IBsalir.IconChar = FontAwesome.Sharp.IconChar.None;
            IBsalir.IconColor = Color.Black;
            IBsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBsalir.Location = new Point(194, 555);
            IBsalir.Margin = new Padding(4);
            IBsalir.Name = "IBsalir";
            IBsalir.Size = new Size(210, 70);
            IBsalir.TabIndex = 12;
            IBsalir.Text = "Salir";
            IBsalir.UseVisualStyleBackColor = false;
            // 
            // IBlimpiar
            // 
            IBlimpiar.BackColor = Color.Silver;
            IBlimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            IBlimpiar.IconColor = Color.Black;
            IBlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBlimpiar.Location = new Point(316, 448);
            IBlimpiar.Margin = new Padding(4);
            IBlimpiar.Name = "IBlimpiar";
            IBlimpiar.Size = new Size(210, 70);
            IBlimpiar.TabIndex = 11;
            IBlimpiar.Text = "Limpiar";
            IBlimpiar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(128, 255, 128);
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(42, 448);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(210, 70);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(272, 357);
            cmbEspecialidad.Margin = new Padding(4);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(295, 38);
            cmbEspecialidad.TabIndex = 9;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(62, 362);
            lblEspecialidad.Margin = new Padding(4, 0, 4, 0);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(132, 30);
            lblEspecialidad.TabIndex = 8;
            lblEspecialidad.Text = "Especialidad:";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(272, 276);
            txtCedula.Margin = new Padding(4);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(295, 35);
            txtCedula.TabIndex = 7;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(62, 280);
            lblCedula.Margin = new Padding(4, 0, 4, 0);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(82, 30);
            lblCedula.TabIndex = 6;
            lblCedula.Text = "Cedula:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(272, 186);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(295, 35);
            txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(62, 190);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(94, 30);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(285, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 30);
            label1.TabIndex = 0;
            label1.Text = "Agregar Médico";
            label1.Click += label1_Click;
            // 
            // FrmAgregarMedico
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 904);
            Controls.Add(panel1);
            Margin = new Padding(4);
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
        private TextBox txtCedula;
        private Label lblCedula;
        private TextBox txtNombre;
        private Label lblNombre;
        private ComboBox cmbEspecialidad;
        private FontAwesome.Sharp.IconButton IBlimpiar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton IBsalir;
    }
}