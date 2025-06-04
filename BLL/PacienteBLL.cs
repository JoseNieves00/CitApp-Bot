using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;
using System.Data;

namespace BLL
{
    public class PacienteBLL
    {
        private static PacienteDAL pacienteDAL = new PacienteDAL();

        public static bool RegistrarPaciente(Paciente paciente)
        {
            if (pacienteDAL.BuscarPorCedula(paciente.Cedula) == null)
            {
                pacienteDAL.AgregarPaciente(paciente);
                return true;
            }
            return false;
        }

        public static Paciente ObtenerPaciente(string cedula)
        {
            return pacienteDAL.BuscarPorCedula(cedula);
        }

        public static DataTable ListarPacientes()
        {
            return pacienteDAL.ListarPacientes();
        }
    }

}

