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
    public partial class FrmPacientes : Form
    {
        public FrmPacientes()
        {
            InitializeComponent();
        }

        private void MostrarPacientes()
        {
            try
            {
                var dt = PacienteBLL.ListarPacientes();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay citas cargadas.");
                }

                dtgvPacientes.DataSource = dt;
                dtgvPacientes.AutoGenerateColumns = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            MostrarPacientes();
        }
    }
}
