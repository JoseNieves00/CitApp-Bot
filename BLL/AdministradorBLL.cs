using System;
using ENTITY;
using DAL;

namespace BLL
{
    public class AdministradorBLL
    {
        private AdministradorDAL adminDAL = new AdministradorDAL();

        public bool Login(string nombre, string contrasena)
        {
            return adminDAL.ValidarLogin(nombre, contrasena);
        }
    }
}
