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
        private static MedicoDAL medicoDAL = new MedicoDAL();

        public static bool RegistrarMedico(Medico medico)
        {
            if (medicoDAL.BuscarPorCedula(medico.Cedula) == null)
            {
                medicoDAL.AgregarMedico(medico);
                return true;
            }
            return false;
        }

        public static List<Medico> ObtenerPorEspecialidad(Especialidad especialidad)
        {
            return medicoDAL.FiltrarPorEspecialidad(especialidad);
        }

        public static Medico ObtenerMedico(string cedula)
        {
            return medicoDAL.BuscarPorCedula(cedula);
        }
    }
}
