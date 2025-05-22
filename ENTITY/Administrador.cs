using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Administrador
    {
        public string Nombre { get; set; }
        public string Contrasena { get; set; }

        public Administrador() { }

        public Administrador(string nombre, string contrasena)
        {
            Nombre = nombre;
            Contrasena = contrasena;
        }
    }
}
