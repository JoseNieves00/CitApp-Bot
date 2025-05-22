namespace CitAppBot
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnLogin = new Button();
            txtContrasena = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 593);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(131, 345);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(184, 61);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "INGRESAR";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(219, 258);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(209, 29);
            txtContrasena.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(219, 188);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(209, 29);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(29, 253);
            label3.Name = "label3";
            label3.Size = new Size(163, 33);
            label3.TabIndex = 1;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(77, 183);
            label2.Name = "label2";
            label2.Size = new Size(115, 33);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(148, 61);
            label1.Name = "label1";
            label1.Size = new Size(134, 44);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 665);
            Controls.Add(panel1);
            Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmLogin";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private TextBox txtContrasena;
        private TextBox txtNombre;
        private Label label3;
    }
}
