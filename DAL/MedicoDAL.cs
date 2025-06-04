using ENTITY;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

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

        public DataTable ListarMedicos()
        {
            DataTable dt = new DataTable();

            try
            {
                AbrirConexion();

                string query = @"
                    SELECT 
                        M.idMedico, 
                        M.nombre, 
                        E.nombre AS especialidad 
                    FROM 
                        medico M
                    INNER JOIN 
                        especialidad E ON M.idEspecialidad = E.idEspecialidad";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, Connection))
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            finally
            {
                CerrarConexion();
            }

            return dt;
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
