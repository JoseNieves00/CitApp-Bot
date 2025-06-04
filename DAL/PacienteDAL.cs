using ENTITY;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

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

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, Connection))
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

        public Paciente BuscarPorCedula(string cedula)
        {
            try
            {
                AbrirConexion();

                string query = "SELECT IdPaciente, Nombre, Apellido, Cedula, Correo, Telefono FROM Paciente WHERE Cedula = @Cedula";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("@Cedula", cedula);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Paciente
                            {
                                Id_paciente = reader.GetInt32(0),
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

        public DataTable ListarPacientes()
        {
            DataTable dt = new DataTable();

            try
            {
                AbrirConexion();

                string query = @"
                    SELECT 
                        idPaciente, 
                        cedula, 
                        nombre, 
                        telefono, 
                        correo 
                    FROM 
                        paciente";

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

    }
}
