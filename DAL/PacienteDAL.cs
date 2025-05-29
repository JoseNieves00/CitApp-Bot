using ENTITY;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace DAL
{
    public class PacienteDAL : Database
    {
        public void AgregarPaciente(Paciente paciente)
        {
            try
            {
                AbrirConexion();

                string query = @"
                    INSERT INTO Paciente (Nombre, Apellido, Cedula, Correo, Telefono)
                    VALUES (@Nombre, @Apellido, @Cedula, @Correo, @Telefono);";

                using (SqlCommand cmd = new SqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("@Nombre", paciente.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", paciente.Apellido);
                    cmd.Parameters.AddWithValue("@Cedula", paciente.Cedula);
                    cmd.Parameters.AddWithValue("@Correo", paciente.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", paciente.Telefono);

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                CerrarConexion();
            }
        }

        public List<Paciente> ListarPacientes()
        {
            List<Paciente> lista = new List<Paciente>();

            try
            {
                AbrirConexion();

                string query = "SELECT IdPaciente, Nombre, Apellido, Cedula, Correo, Telefono FROM Paciente";

                using (SqlCommand cmd = new SqlCommand(query, Connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Paciente
                        {
                            IdPaciente = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            Cedula = reader.GetString(3),
                            Correo = reader.GetString(4),
                            Telefono = reader.GetString(5)
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

        public Paciente BuscarPorCedula(string cedula)
        {
            try
            {
                AbrirConexion();

                string query = "SELECT IdPaciente, Nombre, Apellido, Cedula, Correo, Telefono FROM Paciente WHERE Cedula = @Cedula";

                using (SqlCommand cmd = new SqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("@Cedula", cedula);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Paciente
                            {
                                IdPaciente = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Apellido = reader.GetString(2),
                                Cedula = reader.GetString(3),
                                Correo = reader.GetString(4),
                                Telefono = reader.GetString(5)
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
    }
}
