using ENTITY;
using Npgsql;
using System;
using System.Collections.Generic;

namespace DAL
{
    public class MedicoDAL : Database
    {
        public void AgregarMedico(Medico medico)
        {
            try
            {
                AbrirConexion();

                string query = @"INSERT INTO medico (cedula, nombre,idEspecialidad) VALUES (@Cedula, @Nombre, @IdEspecialidad);";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("@Cedula", medico.Cedula);
                    cmd.Parameters.AddWithValue("@Nombre", medico.Nombre);
                    cmd.Parameters.AddWithValue("@idEspecialidad", medico.Especialidad.Id);
                    
                    cmd.ExecuteNonQuery();
                }

            }
            finally
            {
                CerrarConexion();
            }
        }

        public List<Medico> ListarMedicos()
        {
            List<Medico> lista = new List<Medico>();

            try
            {
                AbrirConexion();

                string query = "SELECT Cedula, Nombre, IdEspecialidad FROM Medico";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, Connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Medico
                        {
                            Cedula = reader.GetString(0),
                            Nombre = reader.GetString(1),
                            Especialidad = new Especialidad
                            {
                                Id = reader.GetInt32(2)
                            }
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

        public Medico BuscarPorCedula(string cedula)
        {
            try
            {
                AbrirConexion();

                string query = "SELECT Cedula, Nombre, IdEspecialidad FROM Medico WHERE Cedula = @Cedula";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("@Cedula", cedula);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Medico
                            {
                                Cedula = reader.GetString(0),
                                Nombre = reader.GetString(1),
                                Especialidad = new Especialidad
                                {
                                    Id = reader.GetInt32(2)
                                }
                            };
                        }
                    }
                }
            }
            finally
            {
                CerrarConexion();
            }

            return null;
        }

        public List<Medico> FiltrarPorEspecialidad(Especialidad especialidad)
        {
            List<Medico> lista = new List<Medico>();

            try
            {
                AbrirConexion();

                string query = "SELECT Cedula, Nombre, IdEspecialidad FROM Medico WHERE IdEspecialidad = @IdEspecialidad";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("@IdEspecialidad", especialidad.Id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Medico
                            {
                                Cedula = reader.GetString(0),
                                Nombre = reader.GetString(1),
                                Especialidad = new Especialidad
                                {
                                    Id = reader.GetInt32(2)
                                }
                            });
                        }
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
