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
            dtgvPacientes = new DataGridView();
            comboBoxVerPacientes = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(dtgvPacientes);
            panel1.Controls.Add(comboBoxVerPacientes);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 783);
            panel1.TabIndex = 1;
            // 
            // dtgvPacientes
            // 
            dtgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPacientes.Location = new Point(363, 54);
            dtgvPacientes.Name = "dtgvPacientes";
            dtgvPacientes.RowHeadersWidth = 72;
            dtgvPacientes.Size = new Size(672, 696);
            dtgvPacientes.TabIndex = 4;
            // 
            // comboBoxVerPacientes
            // 
            comboBoxVerPacientes.FormattingEnabled = true;
            comboBoxVerPacientes.Location = new Point(44, 318);
            comboBoxVerPacientes.Margin = new Padding(4);
            comboBoxVerPacientes.Name = "comboBoxVerPacientes";
            comboBoxVerPacientes.Size = new Size(274, 38);
            comboBoxVerPacientes.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 262);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 30);
            label2.TabIndex = 2;
            label2.Text = "Ver:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 30);
            label1.TabIndex = 1;
            label1.Text = "Pacientes";
            // 
            // FrmPacientes
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 783);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "FrmPacientes";
            Text = "FrmPacientes";
            Load += FrmPacientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBoxVerPacientes;
        private Label label2;
        private Label label1;
        private DataGridView dtgvPacientes;
    }
}