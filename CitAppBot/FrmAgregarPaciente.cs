using BLL;
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
    public partial class FrmAgregarPaciente : Form
    {
        public FrmAgregarPaciente()
        {
            InitializeComponent();
        }

        private void IBlimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPaciente();
        }

        private void IBsalir_Click(object sender, EventArgs e)
        {

        }


        private bool validarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
           string.IsNullOrWhiteSpace(txtApellido.Text) || 
           string.IsNullOrWhiteSpace(txtCedula.Text) ||
           string.IsNullOrWhiteSpace(txtCorreo.Text) ||
           string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Debe completar todos los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                    txtNombre.Focus();
                else if (string.IsNullOrWhiteSpace(txtApellido.Text))
                    txtApellido.Focus();
                else if (string.IsNullOrWhiteSpace(txtCedula.Text))
                    txtCedula.Focus();
                else if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                    txtCorreo.Focus();
                else
                    txtCedula.Focus();


                return false;
            }
            return true;
        }

        private void AgregarPaciente()
        {
            try
            {
                if (!validarCampos())
                    return;

                Paciente paciente = new Paciente
                {
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Cedula = txtCedula.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim()
                };

                bool resultado = PacienteBLL.RegistrarPaciente(paciente);

                if (resultado)
                {
                    MessageBox.Show("Paciente registrado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCedula.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtCedula.Clear();
                    txtCorreo.Clear();
                    txtTelefono.Clear();
                }
                else
                {
                    MessageBox.Show("Ya existe un paciente con esa cédula.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCedula.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
