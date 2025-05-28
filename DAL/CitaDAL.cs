using ENTITY;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace DAL
{
    public class CitaDAL : Database
    {
        public int Registrar(Cita cita)
        {
            try
            {
                AbrirConexion();

                string checkQuery = @"
                    SELECT COUNT(*) 
                    FROM Cita 
                    WHERE IdMedico = @idMedico 
                      AND Fecha = @fecha 
                      AND Hora = @hora 
                      AND Estado <> 'Cancelada'";

                using (var checkCmd = new SqlCommand(checkQuery, Connection))
                {
                    checkCmd.Parameters.AddWithValue("@idMedico", cita.Medico.IdMedico);
                    checkCmd.Parameters.AddWithValue("@fecha", cita.Fecha.Date);
                    checkCmd.Parameters.AddWithValue("@hora", cita.Hora);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0) return -1; // horario ocupado
                }

                string insertQuery = @"
                    INSERT INTO Cita (IdPaciente, IdMedico, Fecha, Hora, Valor, Estado)
                    OUTPUT INSERTED.IdCita
                    VALUES (@idPaciente, @idMedico, @fecha, @hora, @valor, @estado)";

                using (var insertCmd = new SqlCommand(insertQuery, Connection))
                {
                    insertCmd.Parameters.AddWithValue("@idPaciente", cita.Paciente.IdPaciente);
                    insertCmd.Parameters.AddWithValue("@idMedico", cita.Medico.IdMedico);
                    insertCmd.Parameters.AddWithValue("@fecha", cita.Fecha.Date);
                    insertCmd.Parameters.AddWithValue("@hora", cita.Hora);
                    insertCmd.Parameters.AddWithValue("@valor", cita.Valor);
                    insertCmd.Parameters.AddWithValue("@estado", cita.Estado);

                    return (int)insertCmd.ExecuteScalar();
                }
            }
            finally
            {
                CerrarConexion();
            }
        }

        public List<Cita> Listar()
        {
            var citas = new List<Cita>();

            try
            {
                AbrirConexion();

                string query = @"
                    SELECT C.IdCita, C.Fecha, C.Hora, C.Valor, C.Estado,
                           CL.IdPaciente, CL.Nombre AS NombrePaciente,
                           M.IdMedico, M.Nombre AS NombreMedico
                    FROM Cita C
                    INNER JOIN Paciente CL ON C.IdPaciente = CL.IdPaciente
                    INNER JOIN Medico M ON C.IdMedico = M.IdMedico";

                using (var cmd = new SqlCommand(query, Connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        citas.Add(new Cita
                        {
                            IdCita = reader.GetInt32(0),
                            Fecha = reader.GetDateTime(1),
                            Hora = reader.GetTimeSpan(2),
                            Valor = reader.GetDecimal(3),
                            Estado = reader.GetString(4),
                            Paciente = new Paciente
                            {
                                IdPaciente = reader.GetInt32(5),
                                Nombre = reader.GetString(6)
                            },
                            Medico = new Medico
                            {
                                IdMedico = reader.GetInt32(7),
                                Nombre = reader.GetString(8)
                            }
                        });
                    }
                }
            }
            finally
            {
                CerrarConexion();
            }

            return citas;
        }

        public bool ActualizarEstado(int id, string nuevoEstado)
        {
            try
            {
                AbrirConexion();

                string query = "UPDATE Cita SET Estado = @estado WHERE IdCita = @id";
                using (var cmd = new SqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("@estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@id", id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            finally
            {
                CerrarConexion();
            }
        }

        public bool Eliminar(int id)
        {
            try
            {
                AbrirConexion();

                string query = "DELETE FROM Cita WHERE IdCita = @id";
                using (var cmd = new SqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            finally
            {
                CerrarConexion();
            }
        }

        public List<Cita> FiltrarPorEstado(string estado)
        {
            var citas = new List<Cita>();
            try
            {
                AbrirConexion();
                string query = @"
            SELECT C.IdCita, C.Fecha, C.Hora, C.Valor, C.Estado,
                   CL.IdPaciente, CL.Nombre AS NombrePaciente,
                   M.IdMedico, M.Nombre AS NombreMedico
            FROM Cita C
            INNER JOIN Paciente CL ON C.IdPaciente = CL.IdPaciente
            INNER JOIN Medico M ON C.IdMedico = M.IdMedico
            WHERE C.Estado = @estado";

                using (var cmd = new SqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("@estado", estado);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            citas.Add(new Cita
                            {
                                IdCita = reader.GetInt32(0),
                                Fecha = reader.GetDateTime(1),
                                Hora = reader.GetTimeSpan(2),
                                Valor = reader.GetDecimal(3),
                                Estado = reader.GetString(4),
                                Paciente = new Paciente
                                {
                                    IdPaciente = reader.GetInt32(5),
                                    Nombre = reader.GetString(6)
                                },
                                Medico = new Medico
                                {
                                    IdMedico = reader.GetInt32(7),
                                    Nombre = reader.GetString(8)
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
            return citas;
        }


        public Cita BuscarPorId(int id)
        {
            try
            {
                AbrirConexion();

                string query = @"
                    SELECT C.IdCita, C.Fecha, C.Hora, C.Valor, C.Estado,
                           CL.IdPaciente, CL.Nombre AS NombrePaciente,
                           M.IdMedico, M.Nombre AS NombreMedico
                    FROM Cita C
                    INNER JOIN Paciente CL ON C.IdPaciente = CL.IdPaciente
                    INNER JOIN Medico M ON C.IdMedico = M.IdMedico
                    WHERE C.IdCita = @id";

                using (var cmd = new SqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Cita
                            {
                                IdCita = reader.GetInt32(0),
                                Fecha = reader.GetDateTime(1),
                                Hora = reader.GetTimeSpan(2),
                                Valor = reader.GetDecimal(3),
                                Estado = reader.GetString(4),
                                Paciente = new Paciente
                                {
                                    IdPaciente = reader.GetInt32(5),
                                    Nombre = reader.GetString(6)
                                },
                                Medico = new Medico
                                {
                                    IdMedico = reader.GetInt32(7),
                                    Nombre = reader.GetString(8)
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
    }
}
