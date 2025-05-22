using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public class AdministradorBLL
    {
        private AdministradorDAL adminDAL = new AdministradorDAL();

        public bool Login(string nombre, string contrasena)
        {
            Administrador admin = new Administrador
            {
                Nombre = nombre,
                Contrasena = contrasena
            };

            return adminDAL.ValidarLogin(admin);
        }


        public static bool ValidarAcceso(string nombre, string contrasena)
        {
            var admin = AdministradorDAL.ValidarLogin(nombre, contrasena);
            return admin != null;
        }
    }
}
