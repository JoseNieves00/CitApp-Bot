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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarPaciente));
            panel1 = new Panel();
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
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 695);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
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
            panel2.Location = new Point(62, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 579);
            panel2.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(183, 122);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(198, 27);
            txtApellido.TabIndex = 18;
            txtApellido.TextChanged += textBox1_TextChanged;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(43, 125);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 17;
            lblApellido.Text = "Apellido:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(181, 318);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(198, 27);
            txtTelefono.TabIndex = 16;
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
            // txtCorreo
            // 
            txtCorreo.Location = new Point(181, 254);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(198, 27);
            txtCorreo.TabIndex = 14;
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
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(128, 255, 128);
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(37, 418);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 47);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(181, 190);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(198, 27);
            txtCedula.TabIndex = 7;
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
            // txtNombre
            // 
            txtNombre.Location = new Point(181, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(198, 27);
            txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(41, 55);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(191, 20);
            label4.Name = "label4";
            label4.Size = new Size(366, 52);
            label4.TabIndex = 19;
            label4.Text = "Agregar Paciente";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private TextBox txtApellido;
        private Label lblApellido;
        private PictureBox pictureBox1;
        private Label label4;
    }
}