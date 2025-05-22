using ENTITY;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class CitaBLL
    {
        public static string RegistrarCita(Cita cita)
        {
            //var medico = MedicoDAL.BuscarPorCedula(cita.Medico.Cedula);
            //var cliente = ClienteDAL.BuscarPorCedula(cita.Cliente.Cedula);
            //if (medico == null || cliente == null)
            //    return "Médico o cliente no registrado.";

            //bool ocupado = CitaDAL.Listar().Any(c =>
            //    c.Medico.Cedula == cita.Medico.Cedula &&
            //    c.Fecha == cita.Fecha &&
            //    c.Hora == cita.Hora &&
            //    c.Estado == "Agendada"
            //);

            //if (ocupado)
            //    return "Horario ocupado para ese médico.";

            //int id = CitaDAL.Registrar(cita);
            //return $"Cita agendada exitosamente con ID {id}.";
            int id = CitaDAL.Registrar(cita);
            if (id == -1)
                return "Horario ocupado para ese médico.";
            return $"Cita agendada exitosamente con ID {id}.";
        }

        public static string ReagendarCita(int id, DateTime nuevaFecha, TimeSpan nuevaHora)
        {
            var cita = CitaDAL.BuscarPorId(id);
            if (cita == null)
                return "Cita no encontrada.";

            bool ocupado = CitaDAL.Listar().Any(c =>
                c.Medico.Cedula == cita.Medico.Cedula &&
                c.Fecha == nuevaFecha &&
                c.Hora == nuevaHora &&
                c.Estado == "Agendada"
            );

            if (ocupado)
                return "El médico ya tiene una cita en ese horario.";

            cita.Fecha = nuevaFecha;
            cita.Hora = nuevaHora;
            return "Cita reagendada correctamente.";
        }

        public static string EliminarCita(int id)
        {
            var cita = CitaDAL.BuscarPorId(id);
            if (cita == null)
                return "Cita no encontrada.";

            CitaDAL.Eliminar(id);
            return "Cita eliminada.";
        }

        public static string ConfirmarCita(int id)
        {
            var cita = CitaDAL.BuscarPorId(id);
            if (cita == null)
                return "Cita no encontrada.";

            CitaDAL.ActualizarEstado(id, "Confirmada");
            return "Cita confirmada.";
        }

        public static List<Cita> ObtenerPorEstado(string estado)
        {
            return CitaDAL.FiltrarPorEstado(estado);
        }

        public static List<Cita> ListarTodas()
        {
            return CitaDAL.Listar();
        }
    }
}
