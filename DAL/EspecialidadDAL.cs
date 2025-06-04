using ENTITY;
using Npgsql;
using System;
using System.Collections.Generic;

namespace DAL
{
    public class EspecialidadDAL : Database
    {
        public List<Especialidad> ObtenerEspecialidades()
        {
            List<Especialidad> lista = new List<Especialidad>();

            try
            {
                AbrirConexion();

                string query = "SELECT IdEspecialidad, Nombre FROM Especialidad";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, Connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Especialidad
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        });
                    }
                }
            }
            finally
            {
                CerrarConexion();
            }

            return lista;
        }
    }
}
