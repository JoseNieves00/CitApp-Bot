using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Paciente
    {
        public int Id_paciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; } 
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Paciente() { }

        public Paciente(int idPaciente, string nombre, string apellido, string cedula, string correo, string telefono)
        {
            Id_paciente = idPaciente;
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Correo = correo;
            Telefono = telefono;
        }
    }

}
