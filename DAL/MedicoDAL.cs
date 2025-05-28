using ENTITY;
using Microsoft.Data.SqlClient;
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

                string query = @"
                    INSERT INTO Medico (Cedula, Nombre, IdEspecialidad) 
                    VALUES (@Cedula, @Nombre, @IdEspecialidad);";

                using (SqlCommand cmd = new SqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("@Cedula", medico.Cedula);
                    cmd.Parameters.AddWithValue("@Nombre", medico.Nombre);
                    cmd.Parameters.AddWithValue("@IdEspecialidad", (int)medico.Especialidad);

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

                using (SqlCommand cmd = new SqlCommand(query, Connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Medico
                        {
                            Cedula = reader.GetString(0),
                            Nombre = reader.GetString(1),
                            Especialidad = (Especialidad)reader.GetInt32(2)
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

                using (SqlCommand cmd = new SqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("@Cedula", cedula);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Medico
                            {
                                Cedula = reader.GetString(0),
                                Nombre = reader.GetString(1),
                                Especialidad = (Especialidad)reader.GetInt32(2)
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

                using (SqlCommand cmd = new SqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("@IdEspecialidad", (int)especialidad);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Medico
                            {
                                Cedula = reader.GetString(0),
                                Nombre = reader.GetString(1),
                                Especialidad = (Especialidad)reader.GetInt32(2)
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
