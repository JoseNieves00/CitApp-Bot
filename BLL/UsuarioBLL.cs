using System;
using ENTITY;
using DAL;
using System.Data;

namespace BLL
{
    public class UsuarioBLL
    {
        private static UsuarioDAL dal = new UsuarioDAL();

        public static DataTable ValidarLogin(string usuario, string clave)
        {
            return dal.ValidarLogin(usuario, clave);
        }


    }
}
