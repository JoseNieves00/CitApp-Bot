using ENTITY;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class MedicoDAL
    {
        private static List<Medico> listaMedicos = new List<Medico>();

        public static void AgregarMedico(Medico medico)
        {
            listaMedicos.Add(medico);
        }

        public static List<Medico> ListarMedicos()
        {
            return listaMedicos;
        }

        public static Medico BuscarPorCedula(string cedula)
        {
            return listaMedicos.FirstOrDefault(m => m.Cedula == cedula);
        }

        public static List<Medico> FiltrarPorEspecialidad(Especialidad especialidad)
        {
            return listaMedicos.Where(m => m.Especialidad == especialidad).ToList();
        }
    }
}
