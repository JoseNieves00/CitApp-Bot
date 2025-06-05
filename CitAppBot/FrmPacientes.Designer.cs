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
            label4 = new Label();
            dtgvPacientes = new DataGridView();
            comboBoxVerPacientes = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtgvPacientes);
            panel1.Controls.Add(comboBoxVerPacientes);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(583, 598);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(156, 38);
            label4.Name = "label4";
            label4.Size = new Size(215, 52);
            label4.TabIndex = 7;
            label4.Text = "Pacientes";
            // 
            // dtgvPacientes
            // 
            dtgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPacientes.Location = new Point(8, 223);
            dtgvPacientes.Margin = new Padding(2);
            dtgvPacientes.Name = "dtgvPacientes";
            dtgvPacientes.RowHeadersWidth = 72;
            dtgvPacientes.Size = new Size(570, 208);
            dtgvPacientes.TabIndex = 4;
            // 
            // comboBoxVerPacientes
            // 
            comboBoxVerPacientes.FormattingEnabled = true;
            comboBoxVerPacientes.Location = new Point(65, 164);
            comboBoxVerPacientes.Name = "comboBoxVerPacientes";
            comboBoxVerPacientes.Size = new Size(184, 28);
            comboBoxVerPacientes.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 126);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 2;
            label2.Text = "Ver:";
            // 
            // FrmPacientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 598);
            Controls.Add(panel1);
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
        private DataGridView dtgvPacientes;
        private Label label4;
    }
}