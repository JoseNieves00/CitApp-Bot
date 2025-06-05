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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label4 = new Label();
            dtgvCitas = new DataGridView();
            citaBLLBindingSource = new BindingSource(components);
            comboBoxVerCitas = new ComboBox();
            label2 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCitas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)citaBLLBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtgvCitas);
            panel1.Controls.Add(comboBoxVerCitas);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 536);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(80, 37);
            label4.Name = "label4";
            label4.Size = new Size(121, 52);
            label4.TabIndex = 8;
            label4.Text = "Citas";
            // 
            // dtgvCitas
            // 
            dtgvCitas.AutoGenerateColumns = false;
            dtgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCitas.DataSource = citaBLLBindingSource;
            dtgvCitas.Location = new Point(5, 233);
            dtgvCitas.Margin = new Padding(2);
            dtgvCitas.Name = "dtgvCitas";
            dtgvCitas.ReadOnly = true;
            dtgvCitas.RowHeadersWidth = 72;
            dtgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvCitas.Size = new Size(549, 206);
            dtgvCitas.TabIndex = 4;
            // 
            // citaBLLBindingSource
            // 
            citaBLLBindingSource.DataSource = typeof(BLL.CitaBLL);
            // 
            // comboBoxVerCitas
            // 
            comboBoxVerCitas.FormattingEnabled = true;
            comboBoxVerCitas.Location = new Point(55, 182);
            comboBoxVerCitas.Name = "comboBoxVerCitas";
            comboBoxVerCitas.Size = new Size(184, 28);
            comboBoxVerCitas.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 145);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 2;
            label2.Text = "Ver:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 536);
            Controls.Add(panel1);
            Name = "FrmCitas";
            Text = "FrmCitas";
            Load += FrmCitas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCitas).EndInit();
            ((System.ComponentModel.ISupportInitialize)citaBLLBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private VScrollBar vScrollBarCitas;
        private ComboBox comboBoxVerCitas;
        private Label label2;
        private DataGridView dtgvCitas;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private BindingSource citaBLLBindingSource;
        private Label label4;
    }
}