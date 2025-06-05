namespace CitAppBot
{
    partial class FrmMedicos
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
            label1 = new Label();
            label2 = new Label();
            comboBoxVerMedicos = new ComboBox();
            dtgvMedicos = new DataGridView();
            panel1 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvMedicos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 155);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 2;
            label2.Text = "Ver:";
            // 
            // comboBoxVerMedicos
            // 
            comboBoxVerMedicos.FormattingEnabled = true;
            comboBoxVerMedicos.Location = new Point(48, 192);
            comboBoxVerMedicos.Name = "comboBoxVerMedicos";
            comboBoxVerMedicos.Size = new Size(184, 28);
            comboBoxVerMedicos.TabIndex = 3;
            // 
            // dtgvMedicos
            // 
            dtgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvMedicos.Location = new Point(48, 245);
            dtgvMedicos.Margin = new Padding(2);
            dtgvMedicos.Name = "dtgvMedicos";
            dtgvMedicos.RowHeadersWidth = 72;
            dtgvMedicos.Size = new Size(451, 204);
            dtgvMedicos.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtgvMedicos);
            panel1.Controls.Add(comboBoxVerMedicos);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 609);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(135, 36);
            label4.Name = "label4";
            label4.Size = new Size(188, 52);
            label4.TabIndex = 8;
            label4.Text = "Médicos";
            // 
            // FrmMedicos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 609);
            Controls.Add(panel1);
            Name = "FrmMedicos";
            Text = "FrmMedicos";
            Load += FrmMedicos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvMedicos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private VScrollBar vScrollBarMedicos;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxVerMedicos;
        private DataGridView dtgvMedicos;
        private Panel panel1;
        private Label label4;
    }
}