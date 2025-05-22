using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Medico
    {
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public Especialidad Especialidad { get; set; }

        public Medico() { }

        public Medico(string nombre, string cedula, Especialidad especialidad)
        {
            Nombre = nombre;
            Cedula = cedula;
            Especialidad = especialidad;
        }
    }
}
