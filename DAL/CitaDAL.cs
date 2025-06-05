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
                    INSERT INTO Cita (IdPaciente, IdMedico, Fecha, Hora, Estado)
                    OUTPUT INSERTED.IdCita
                    VALUES (@idPaciente, @idMedico, @fecha, @hora, @estado)";

                using (var insertCmd = new NpgsqlCommand(insertQuery, Connection))
                {
                    insertCmd.Parameters.AddWithValue("@idPaciente", cita.Paciente.Idpaciente);
                    insertCmd.Parameters.AddWithValue("@idMedico", cita.Medico.IdMedico);
                    insertCmd.Parameters.AddWithValue("@fecha", cita.Fecha.Date);
                    insertCmd.Parameters.AddWithValue("@hora", cita.Hora);
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

        public List<Cita> ListCitas()
        {
            var citas = new List<Cita>();

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
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            citas.Add(new Cita
                            {
                                IdCita = reader.GetInt32(0),
                                Fecha = reader.GetDateTime(reader.GetOrdinal("fecha")),
                                Hora = reader.GetTimeSpan(2),
                                Estado = reader.GetString(3),
                                Paciente = new Paciente
                                {
                                    Idpaciente = reader.GetInt32(5),
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

        //public bool ActualizarEstado(int id, string nuevoEstado)
        //{
        //    try
        //    {
        //        AbrirConexion();

        //        string query = "UPDATE Cita SET Estado = @estado WHERE IdCita = @id";
        //        using (var cmd = new NpgsqlCommand(query, Connection))
        //        {
        //            cmd.Parameters.AddWithValue("@estado", nuevoEstado);
        //            cmd.Parameters.AddWithValue("@id", id);

        //            return cmd.ExecuteNonQuery() > 0;
        //        }
        //    }
        //    finally
        //    {
        //        CerrarConexion();
        //    }
        //}

        //public bool Eliminar(int id)
        //{
        //    try
        //    {
        //        AbrirConexion();

        //        string query = "DELETE FROM Cita WHERE IdCita = @id";
        //        using (var cmd = new NpgsqlCommand(query, Connection))
        //        {
        //            cmd.Parameters.AddWithValue("@id", id);
        //            return cmd.ExecuteNonQuery() > 0;
        //        }
        //    }
        //    finally
        //    {
        //        CerrarConexion();
        //    }
        //}

        //public List<Cita> FiltrarPorEstado(string estado)
        //{
        //    var citas = new List<Cita>();
        //    try
        //    {
        //        AbrirConexion();
        //        string query = @"
        //    SELECT C.IdCita, C.Fecha, C.Hora, C.Valor, C.Estado,
        //           CL.IdPaciente, CL.Nombre AS NombrePaciente,
        //           M.IdMedico, M.Nombre AS NombreMedico
        //    FROM Cita C
        //    INNER JOIN Paciente CL ON C.IdPaciente = CL.IdPaciente
        //    INNER JOIN Medico M ON C.IdMedico = M.IdMedico
        //    WHERE C.Estado = @estado";

        //        using (var cmd = new NpgsqlCommand(query, Connection))
        //        {
        //            cmd.Parameters.AddWithValue("@estado", estado);
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    citas.Add(new Cita
        //                    {
        //                        IdCita = reader.GetInt32(0),
        //                        Fecha = reader.GetDateTime(1),
        //                        Hora = reader.GetTimeSpan(2),
        //                        Estado = reader.GetString(3),
        //                        Paciente = new Paciente
        //                        {
        //                            Idpaciente = reader.GetInt32(5),
        //                            Nombre = reader.GetString(6)
        //                        },
        //                        Medico = new Medico
        //                        {
        //                            IdMedico = reader.GetInt32(7),
        //                            Nombre = reader.GetString(8)
        //                        }
        //                    });
        //                }
        //            }
        //        }
        //    }
        //    finally
        //    {
        //        CerrarConexion();
        //    }
        //    return citas;
        //}


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
                                Estado = reader.GetString(3),
                                Paciente = new Paciente
                                {
                                    Idpaciente = reader.GetInt32(5),
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

        public List<Cita> ListarPorCedula(string cedula)
        {
            List<Cita> lista = new List<Cita>();

            string query = @"
        SELECT 
    c.idcita, c.fecha, c.hora, c.estado,
        p.idpaciente, p.nombre AS paciente_nombre, p.apellido, p.cedula,
            m.idmedico, m.nombre AS medico_nombre,
                e.idespecialidad, e.nombre AS especialidad_nombre
                FROM cita c
                INNER JOIN paciente p ON c.idpaciente = p.idpaciente
                INNER JOIN medico m ON c.idmedico = m.idmedico
                INNER JOIN especialidad e ON m.idespecialidad = e.idespecialidad
                WHERE p.cedula = @cedula;";

            using (var cmd = new NpgsqlCommand(query, Connection))
            {
                cmd.Parameters.AddWithValue("@cedula", cedula);

                Connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var paciente = new Paciente
                        {
                            Idpaciente = reader.GetInt32(4),
                            Nombre = reader.GetString(5),
                            Apellido = reader.GetString(6),
                            Cedula = reader.GetString(7)
                        };

                        var especialidad = new Especialidad
                        {
                            Id = reader.GetInt32(10),
                            Nombre = reader.GetString(11)
                        };

                        var medico = new Medico
                        {
                            IdMedico = reader.GetInt32(8),
                            Nombre = reader.GetString(9),
                            Especialidad = especialidad
                        };

                        var cita = new Cita
                        {
                            IdCita = reader.GetInt32(0),
                            Fecha = reader.GetDateTime(1),
                            Hora = reader.GetTimeSpan(2),
                            Estado = reader.GetString(3),
                            Paciente = paciente,
                            Medico = medico
                        };

                        lista.Add(cita);
                    }
                }

                Connection.Close();
            }

            return lista;
        }

        public List<TimeSpan> ObtenerHorariosDisponibles(int idMedico, DateTime fecha)
        {
            List<TimeSpan> horariosOcupados = new List<TimeSpan>();
            List<TimeSpan> horariosDisponibles = new List<TimeSpan>();

            string query = "SELECT hora FROM cita WHERE idmedico = @idmedico AND fecha = @fecha";

            using (var cmd = new NpgsqlCommand(query, Connection))
            {
                cmd.Parameters.AddWithValue("@idmedico", idMedico);
                cmd.Parameters.AddWithValue("@fecha", fecha);

                Connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        horariosOcupados.Add(reader.GetTimeSpan(0));
                    }
                }

                Connection.Close();
            }

            for (int hora = 8; hora < 17; hora++)
            {
                var h = new TimeSpan(hora, 0, 0);
                if (!horariosOcupados.Contains(h))
                {
                    horariosDisponibles.Add(h);
                }
            }

            return horariosDisponibles;
        }
    }
}
