using System;
using ENTITY;
using DAL;

namespace BLL
{
    public class UsuarioBLL
    {
        private UsuarioDAL adminDAL = new UsuarioDAL();

        public bool Login(string nombre, string contrasena)
        {
            return adminDAL.ValidarLogin(nombre, contrasena);
        }
    }
}
