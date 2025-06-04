using BLL;
using DAL;
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
    public partial class FrmCitas : Form
    {
        public FrmCitas()
        {
            InitializeComponent();
        }

        private void MostrarCitas()
        {
            try
            {
                var dt = CitaBLL.ListarTodas();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay citas cargadas.");
                }

                dtgvCitas.DataSource = dt;
                dtgvCitas.AutoGenerateColumns=true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            MostrarCitas();
        }
    }
}
