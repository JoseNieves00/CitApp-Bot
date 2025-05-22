using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public class MedicoBLL
    {
        public static bool RegistrarMedico(Medico medico)
        {
            if (MedicoDAL.BuscarPorCedula(medico.Cedula) == null)
            {
                MedicoDAL.AgregarMedico(medico);
                return true;
            }
            return false;
        }

        public static List<Medico> ObtenerPorEspecialidad(Especialidad especialidad)
        {
            return MedicoDAL.FiltrarPorEspecialidad(especialidad);
        }

        public static Medico ObtenerMedico(string cedula)
        {
            return MedicoDAL.BuscarPorCedula(cedula);
        }
    }
}
