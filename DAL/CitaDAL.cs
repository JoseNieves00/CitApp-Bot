using ENTITY;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

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

                using (var checkCmd = new NpgsqlCommand(checkQuery, Connection))
                {
                    checkCmd.Parameters.AddWithValue("@fecha", cita.Fecha.Date);
                    checkCmd.Parameters.AddWithValue("@hora", cita.Hora);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0) return -1; // horario ocupado
                }

                string insertQuery = @"
                    INSERT INTO Cita (IdPaciente, IdMedico, Fecha, Hora, Valor, Estado)
                    OUTPUT INSERTED.IdCita
                    VALUES (@idPaciente, @idMedico, @fecha, @hora, @valor, @estado)";

                using (var insertCmd = new NpgsqlCommand(insertQuery, Connection))
                {
                    insertCmd.Parameters.AddWithValue("@idPaciente", cita.Paciente.Id_paciente);
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

        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            try
            {
                AbrirConexion();

                string query = @"
                    SELECT 
                        C.idCita, 
                        P.nombre AS nombrePaciente, 
                        M.nombre AS nombreMedico, 
                        E.nombre AS especialidad, 
                        C.fecha, 
                        C.hora, 
                        C.estado
                    FROM 
                        cita C
                    INNER JOIN 
                        paciente P ON C.idPaciente = P.idPaciente
                    INNER JOIN 
                        medico M ON C.idMedico = M.idMedico
                    INNER JOIN 
                        especialidad E ON M.idEspecialidad = E.idEspecialidad;";

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

        public bool ActualizarEstado(int id, string nuevoEstado)
        {
            try
            {
                AbrirConexion();

                string query = "UPDATE Cita SET Estado = @estado WHERE IdCita = @id";
                using (var cmd = new NpgsqlCommand(query, Connection))
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
                using (var cmd = new NpgsqlCommand(query, Connection))
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

                using (var cmd = new NpgsqlCommand(query, Connection))
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
                                    Id_paciente = reader.GetInt32(5),
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

                using (var cmd = new NpgsqlCommand(query, Connection))
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
                                    Id_paciente = reader.GetInt32(5),
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
