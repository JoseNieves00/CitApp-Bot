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
            comboBoxVerMedicos = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            vScrollBarMedicos = new VScrollBar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(comboBoxVerMedicos);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(vScrollBarMedicos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 586);
            panel1.TabIndex = 1;
            // 
            // comboBoxVerMedicos
            // 
            comboBoxVerMedicos.FormattingEnabled = true;
            comboBoxVerMedicos.Location = new Point(29, 212);
            comboBoxVerMedicos.Name = "comboBoxVerMedicos";
            comboBoxVerMedicos.Size = new Size(184, 28);
            comboBoxVerMedicos.TabIndex = 3;
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
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "Médicos";
            // 
            // vScrollBarMedicos
            // 
            vScrollBarMedicos.Location = new Point(247, 9);
            vScrollBarMedicos.Name = "vScrollBarMedicos";
            vScrollBarMedicos.Size = new Size(447, 508);
            vScrollBarMedicos.TabIndex = 0;
            // 
            // FrmMedicos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 586);
            Controls.Add(panel1);
            Name = "FrmMedicos";
            Text = "FrmMedicos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBoxVerMedicos;
        private Label label2;
        private Label label1;
        private VScrollBar vScrollBarMedicos;
    }
}