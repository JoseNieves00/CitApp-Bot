using ENTITY;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DAL
{
    public class AdministradorDAL : Database
    {
        public Administrador ObtenerAdministrador(string usuario, string contrasena)
        {
            try
            {
                AbrirConexion();

                string query = @"
                    SELECT u.IdUsuario, u.Usuario, u.Contrasena, r.IdRol, r.NombreRol
                    FROM Usuario u
                    INNER JOIN Rol r ON u.IdRol = r.IdRol
                    WHERE u.Usuario = @usuario AND u.Contrasena = @contrasena";

                using (SqlCommand cmd = new SqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Administrador
                            {
                                IdUsuario = reader.GetInt32(0),
                                Usuario = reader.GetString(1),
                                Contrasena = reader.GetString(2),
                                IdRol = reader.GetInt32(3),
                                NombreRol = reader.GetString(4)
                            };
                        }
                    }
                }

                return null;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public bool ValidarLogin(string usuario, string contrasena)
        {
            var admin = ObtenerAdministrador(usuario, contrasena);
            return admin != null && admin.NombreRol == "Administrador";
        }
    }
}
