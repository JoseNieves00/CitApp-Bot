using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public int IdRol { get; set; }
        public string NombreRol { get; set; }

        public Usuario() { }

        public Usuario(string usuario, string contrasena)
        {
            NombreUsuario = usuario;
            Contrasena = contrasena;
        }
    }
}
