namespace CitAppBot
{
    partial class FrmPacientes
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
            comboBoxVerPacientes = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            vScrollBarPacientes = new VScrollBar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(comboBoxVerPacientes);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(vScrollBarPacientes);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 522);
            panel1.TabIndex = 1;
            // 
            // comboBoxVerPacientes
            // 
            comboBoxVerPacientes.FormattingEnabled = true;
            comboBoxVerPacientes.Location = new Point(29, 212);
            comboBoxVerPacientes.Name = "comboBoxVerPacientes";
            comboBoxVerPacientes.Size = new Size(184, 28);
            comboBoxVerPacientes.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 175);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 2;
            label2.Text = "Ver:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 36);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "Pacientes";
            // 
            // vScrollBarPacientes
            // 
            vScrollBarPacientes.Location = new Point(247, 9);
            vScrollBarPacientes.Name = "vScrollBarPacientes";
            vScrollBarPacientes.Size = new Size(447, 508);
            vScrollBarPacientes.TabIndex = 0;
            // 
            // FrmPacientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 522);
            Controls.Add(panel1);
            Name = "FrmPacientes";
            Text = "FrmPacientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBoxVerPacientes;
        private Label label2;
        private Label label1;
        private VScrollBar vScrollBarPacientes;
    }
}