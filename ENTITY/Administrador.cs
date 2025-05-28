using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Administrador
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public int IdRol { get; set; }
        public string NombreRol { get; set; }

        public Administrador() { }

        public Administrador(string usuario, string contrasena)
        {
            Usuario = usuario;
            Contrasena = contrasena;
        }
    }
}
