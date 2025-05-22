using ENTITY;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class AdministradorDAL : Database
    {
        public bool ValidarLogin(Administrador admin)
        {
            try
            {
                AbrirConexion();

                string query = "SELECT COUNT(*) FROM Administrador WHERE Nombre = @nombre AND Contrasena = @contrasena";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.Parameters.AddWithValue("@nombre", admin.Nombre);
                cmd.Parameters.AddWithValue("@contrasena", admin.Contrasena);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            finally
            {
                CerrarConexion();
            }
        }
        private static List<Administrador> listaAdmins = new List<Administrador>()
        {
            new Administrador("admin", "1234") 
        };

        public static Administrador ValidarLogin(string nombre, string contrasena)
        {
            return listaAdmins.FirstOrDefault(a => a.Nombre == nombre && a.Contrasena == contrasena);
        }
    }
}
