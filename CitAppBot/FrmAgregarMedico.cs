using BLL;
using DAL;
using ENTITY;
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
    public partial class FrmAgregarMedico : Form
    {
        public FrmAgregarMedico()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        }

        private void FrmAgregarMedico_Load(object sender, EventArgs e)
        {
            cargarEspecialidades();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cargarEspecialidades()
        {
            EspecialidadDAL especialidadDAL = new EspecialidadDAL();
            List<Especialidad> lista = especialidadDAL.ObtenerEspecialidades();

            cmbEspecialidad.DataSource = lista;
            cmbEspecialidad.DisplayMember = "Nombre";
            cmbEspecialidad.ValueMember = "Id";
        }

        private bool validarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text) ||
           string.IsNullOrWhiteSpace(txtNombre.Text) ||
           cmbEspecialidad.SelectedItem == null)
            {
                MessageBox.Show("Debe completar todos los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (string.IsNullOrWhiteSpace(txtCedula.Text))
                    txtCedula.Focus();
                else if (string.IsNullOrWhiteSpace(txtNombre.Text))
                    txtNombre.Focus();
                else
                    cmbEspecialidad.Focus();

                return false;
            }
            return true;
        }

        private void AgregarMedico()
        {
            try
            {
                if (!validarCampos())
                    return;

                Medico medico = new Medico
                {
                    Cedula = txtCedula.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Especialidad = (Especialidad)cmbEspecialidad.SelectedItem
                };

                bool resultado = MedicoBLL.RegistrarMedico(medico);

                if (resultado)
                {
                    MessageBox.Show("Médico registrado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCedula.Clear();
                    txtNombre.Clear();
                    cmbEspecialidad.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Ya existe un médico con esa cédula.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCedula.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar médico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarMedico();
        }
    }
}
