using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public static class UsuarioSession
    {
        public static int IdUsuario { get; set; }
        public static string NombreUsuario { get; set; }
        public static int IdRol { get; set; }
        public static string NombreRol { get; set; }
        public static string CedulaPersona { get; set; }

        public static void CerrarSesion()
        {
            IdUsuario = 0;
            NombreUsuario = null;
            IdRol = 0;
            NombreRol = null;
            CedulaPersona = null;
        }
    }
}
