using ENTITY;
using Npgsql;
using System;
using System.Data;

namespace DAL
{
    public class UsuarioDAL : Database
    {
        public Usuario ObtenerUsuario(string usuario, string contrasena)
        {
            try
            {
                AbrirConexion();

                string query = @"
                    SELECT 
                        u.id_usuario, u.usuario, u.clave, r.id_rol, r.nombre
                    FROM 
                        usuario u
                    INNER JOIN 
                        rol r ON u.id_rol = r.id_rol
                    WHERE 
                        u.usuario = @usuario AND u.clave = @contrasena
                    LIMIT 1;";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Usuario
                            {
                                IdUsuario = reader.GetInt32(0),
                                NombreUsuario = reader.GetString(1),
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
            var admin = ObtenerUsuario(usuario, contrasena);
            return admin != null && admin.NombreRol == "Administrador";
        }
    }
}
