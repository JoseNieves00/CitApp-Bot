using ENTITY;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace BLL
{
    public class CitaBLL
    {
        private static CitaDAL citaDAL = new CitaDAL();

        public static string AgendarCita(Cita cita)
        {
            var medico = cita.Medico;
            var paciente = cita.Paciente;

            if (medico == null)
                return "Error: Médico no especificado.";

            if (paciente == null)
                return "Error: Paciente no especificado.";

            bool ocupado = citaDAL.ListCitas().Any(c =>
                c.Medico.IdMedico == medico.IdMedico &&
                c.Fecha.Date == cita.Fecha.Date &&
                c.Hora == cita.Hora &&
                c.Estado != "Cancelada"
            );

            if (ocupado)
                return $"Error: El médico {medico.Nombre} ya tiene una cita agendada para {cita.Fecha:dd/MM/yyyy} a las {cita.Hora:hh\\:mm}.";

            int id = citaDAL.Registrar(cita);
            if (id == -1)
                return "Error: No se pudo registrar la cita, inténtalo más tarde.";

            return "exito";  // Mensaje para éxito
        }

        //public static string ReagendarCita(int id, DateTime nuevaFecha, TimeSpan nuevaHora)
        //{
        //    var cita = citaDAL.BuscarPorId(id);
        //    if (cita == null)
        //        return "Cita no encontrada.";

        //    bool ocupado = citaDAL.Listar().Any(c =>
        //        c.Medico.IdMedico == cita.Medico.IdMedico &&
        //        c.Fecha.Date == nuevaFecha.Date &&
        //        c.Hora == nuevaHora &&
        //        c.Estado != "Cancelada"
        //    );

        //    if (ocupado)
        //        return "El médico ya tiene una cita en ese horario.";


        //    cita.Fecha = nuevaFecha;
        //    cita.Hora = nuevaHora;
        //    citaDAL.ActualizarEstado(id, "Reagendada");

        //    return "Cita reagendada correctamente.";
        //}

        //public static string EliminarCita(int id)
        //{
        //    var cita = citaDAL.BuscarPorId(id);
        //    if (cita == null)
        //        return "Cita no encontrada.";

        //    citaDAL.Eliminar(id);
        //    return "Cita eliminada.";
        //}

        //public static string ConfirmarCita(int id)
        //{
        //    var cita = citaDAL.BuscarPorId(id);
        //    if (cita == null)
        //        return "Cita no encontrada.";

        //    citaDAL.ActualizarEstado(id, "Confirmada");
        //    return "Cita confirmada.";
        //}

        //public static List<Cita> ObtenerPorEstado(string estado)
        //{
        //    return citaDAL.Listar().Where(c => c.Estado == estado).ToList();
        //}

        public static DataTable ListarTodas()
        {
            return citaDAL.Listar();
        }

        public List<Cita> ObtenerCitasPorCedula(string cedula)
        {
            if (string.IsNullOrWhiteSpace(cedula))
                return new List<Cita>();

            return citaDAL.ListarPorCedula(cedula);
        }

        public static List<TimeSpan> ObtenerHorariosDisponibles(Medico medico, DateTime fecha)
        {
            return citaDAL.ObtenerHorariosDisponibles(medico.IdMedico,fecha);
        }
    }
}
