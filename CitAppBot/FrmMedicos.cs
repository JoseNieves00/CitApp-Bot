using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitAppBot
{
    public partial class FrmMedicos : Form
    {
        public FrmMedicos()
        {
            InitializeComponent();
        }

        private void FrmMedicos_Load(object sender, EventArgs e)
        {
            MostrarMedicos();
        }

        private void MostrarMedicos()
        {
            try
            {
                var dt = MedicoBLL.ListarMedicos();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay citas cargadas.");
                }

                dtgvMedicos.DataSource = dt;
                dtgvMedicos.AutoGenerateColumns = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
