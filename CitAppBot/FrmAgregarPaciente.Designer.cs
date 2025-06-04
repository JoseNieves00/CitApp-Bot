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
            label1 = new Label();
            panel2 = new Panel();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            IBsalir = new FontAwesome.Sharp.IconButton();
            IBlimpiar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            txtCedula = new TextBox();
            lblCedula = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
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
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 1042);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 30);
            label1.TabIndex = 17;
            label1.Text = "Agregar Paciente";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(txtApellido);
            panel2.Controls.Add(lblApellido);
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(lblTelefono);
            panel2.Controls.Add(txtCorreo);
            panel2.Controls.Add(lblCorreo);
            panel2.Controls.Add(IBsalir);
            panel2.Controls.Add(IBlimpiar);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(txtCedula);
            panel2.Controls.Add(lblCedula);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(lblNombre);
            panel2.Location = new Point(93, 90);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(669, 902);
            panel2.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(275, 183);
            txtApellido.Margin = new Padding(4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(295, 35);
            txtApellido.TabIndex = 18;
            txtApellido.TextChanged += textBox1_TextChanged;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(65, 187);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(94, 30);
            lblApellido.TabIndex = 17;
            lblApellido.Text = "Apellido:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(272, 477);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(295, 35);
            txtTelefono.TabIndex = 16;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(62, 482);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(97, 30);
            lblTelefono.TabIndex = 15;
            lblTelefono.Text = "Telefono:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(272, 381);
            txtCorreo.Margin = new Padding(4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(295, 35);
            txtCorreo.TabIndex = 14;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(62, 386);
            lblCorreo.Margin = new Padding(4, 0, 4, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(80, 30);
            lblCorreo.TabIndex = 13;
            lblCorreo.Text = "Correo:";
            // 
            // IBsalir
            // 
            IBsalir.BackColor = Color.FromArgb(255, 128, 128);
            IBsalir.IconChar = FontAwesome.Sharp.IconChar.None;
            IBsalir.IconColor = Color.Black;
            IBsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBsalir.Location = new Point(207, 734);
            IBsalir.Margin = new Padding(4);
            IBsalir.Name = "IBsalir";
            IBsalir.Size = new Size(210, 70);
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
            IBlimpiar.Location = new Point(330, 627);
            IBlimpiar.Margin = new Padding(4);
            IBlimpiar.Name = "IBlimpiar";
            IBlimpiar.Size = new Size(210, 70);
            IBlimpiar.TabIndex = 11;
            IBlimpiar.Text = "Limpiar";
            IBlimpiar.UseVisualStyleBackColor = false;
            IBlimpiar.Click += IBlimpiar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(128, 255, 128);
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(56, 627);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(210, 70);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(272, 285);
            txtCedula.Margin = new Padding(4);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(295, 35);
            txtCedula.TabIndex = 7;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(62, 290);
            lblCedula.Margin = new Padding(4, 0, 4, 0);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(82, 30);
            lblCedula.TabIndex = 6;
            lblCedula.Text = "Cedula:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(272, 79);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(295, 35);
            txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(62, 83);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(94, 30);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // FrmAgregarPaciente
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 1042);
            Controls.Add(panel1);
            Margin = new Padding(4);
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
        private FontAwesome.Sharp.IconButton btnAgregar;
        private TextBox txtCedula;
        private Label lblCedula;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label label1;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private TextBox txtApellido;
        private Label lblApellido;
    }
}