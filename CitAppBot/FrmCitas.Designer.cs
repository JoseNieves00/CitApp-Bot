namespace CitAppBot
{
    partial class FrmCitas
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
            vScrollBarCitas = new VScrollBar();
            label1 = new Label();
            label2 = new Label();
            comboBoxVerCitas = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(comboBoxVerCitas);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(vScrollBarCitas);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 535);
            panel1.TabIndex = 0;
            // 
            // vScrollBarCitas
            // 
            vScrollBarCitas.Location = new Point(247, 9);
            vScrollBarCitas.Name = "vScrollBarCitas";
            vScrollBarCitas.Size = new Size(447, 508);
            vScrollBarCitas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 36);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 1;
            label1.Text = "Citas";
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
            // comboBoxVerCitas
            // 
            comboBoxVerCitas.FormattingEnabled = true;
            comboBoxVerCitas.Location = new Point(29, 212);
            comboBoxVerCitas.Name = "comboBoxVerCitas";
            comboBoxVerCitas.Size = new Size(184, 28);
            comboBoxVerCitas.TabIndex = 3;
            // 
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 535);
            Controls.Add(panel1);
            Name = "FrmCitas";
            Text = "FrmCitas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private VScrollBar vScrollBarCitas;
        private ComboBox comboBoxVerCitas;
        private Label label2;
    }
}