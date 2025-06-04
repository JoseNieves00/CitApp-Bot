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
            panel1 = new Panel();
            dtgvMedicos = new DataGridView();
            comboBoxVerMedicos = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvMedicos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(dtgvMedicos);
            panel1.Controls.Add(comboBoxVerMedicos);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 879);
            panel1.TabIndex = 1;
            // 
            // dtgvMedicos
            // 
            dtgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvMedicos.Location = new Point(372, 54);
            dtgvMedicos.Name = "dtgvMedicos";
            dtgvMedicos.RowHeadersWidth = 72;
            dtgvMedicos.Size = new Size(722, 787);
            dtgvMedicos.TabIndex = 4;
            // 
            // comboBoxVerMedicos
            // 
            comboBoxVerMedicos.FormattingEnabled = true;
            comboBoxVerMedicos.Location = new Point(44, 318);
            comboBoxVerMedicos.Margin = new Padding(4);
            comboBoxVerMedicos.Name = "comboBoxVerMedicos";
            comboBoxVerMedicos.Size = new Size(274, 38);
            comboBoxVerMedicos.TabIndex = 3;
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
            label1.Size = new Size(91, 30);
            label1.TabIndex = 1;
            label1.Text = "Médicos";
            // 
            // FrmMedicos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 879);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "FrmMedicos";
            Text = "FrmMedicos";
            Load += FrmMedicos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvMedicos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBoxVerMedicos;
        private Label label2;
        private Label label1;
        private VScrollBar vScrollBarMedicos;
        private DataGridView dtgvMedicos;
    }
}