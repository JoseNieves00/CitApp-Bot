using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public static class CitaDAL
    {
        private static List<Cita> listaCitas = new List<Cita>();
        private static int idActual = 1;

        // Método utilizado por CitaBLL.RegistrarCita()
        public static int AgregarCita(Cita cita)
        {
            cita.IdCita = idActual++;
            listaCitas.Add(cita);
            return cita.IdCita;
        }

        // Método utilizado por CitaBLL.ListarTodas()
        public static List<Cita> Listar()
        {
            return listaCitas;
        }

        // Método utilizado por CitaBLL.BuscarPorId()
        public static Cita BuscarPorId(int id)
        {
            return listaCitas.FirstOrDefault(c => c.IdCita == id);
        }

        // Método utilizado por CitaBLL.EliminarCita()
        public static void EliminarCita(int id)
        {
            var cita = BuscarPorId(id);
            if (cita != null)
            {
                listaCitas.Remove(cita);
            }
        }

        // Método utilizado por CitaBLL.ConfirmarCita()
        public static void ActualizarEstado(int id, string nuevoEstado)
        {
            var cita = BuscarPorId(id);
            if (cita != null)
            {
                cita.Estado = nuevoEstado;
            }
        }

        // Método utilizado por CitaBLL.ObtenerPorEstado()
        public static List<Cita> FiltrarPorEstado(string estado)
        {
            return listaCitas
                .Where(c => c.Estado.Equals(estado, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Método adicional si deseas cancelar una cita (opcional)
        public static string Cancelar(int id)
        {
            var cita = BuscarPorId(id);
            if (cita == null)
                return "No se encontró la cita.";

            if (cita.Estado == "Cancelada")
                return "La cita ya está cancelada.";

            cita.Estado = "Cancelada";
            return "Cita cancelada correctamente.";
        }

        // Método adicional si deseas confirmar una cita con validación (opcional)
        public static string Confirmar(int id)
        {
            var cita = BuscarPorId(id);
            if (cita == null)
                return "No se encontró la cita.";

            if (cita.Estado == "Confirmada")
                return "La cita ya está confirmada.";

            cita.Estado = "Confirmada";
            return "Cita confirmada correctamente.";
        }

        // Método adicional si deseas reagendar una cita con validación (opcional)
        public static string Reagendar(int id, DateTime nuevaFecha, TimeSpan nuevaHora)
        {
            var cita = BuscarPorId(id);
            if (cita == null)
                return "No se encontró la cita.";

            bool ocupada = listaCitas.Any(c =>
                c.Medico.Cedula == cita.Medico.Cedula &&
                c.Fecha.Date == nuevaFecha.Date &&
                c.Hora == nuevaHora &&
                c.Estado != "Cancelada" &&
                c.IdCita != id);

            if (ocupada)
                return "No se puede reagendar, el horario ya está ocupado.";

            cita.Fecha = nuevaFecha;
            cita.Hora = nuevaHora;
            cita.Estado = "Reagendada";
            return "Cita reagendada correctamente.";
        }

        public static int Registrar(Cita cita)
        {
            bool ocupada = listaCitas.Any(c =>
                c.Medico.Cedula == cita.Medico.Cedula &&
                c.Fecha.Date == cita.Fecha.Date &&
                c.Hora == cita.Hora &&
                c.Estado != "Cancelada");

            if (ocupada)
            {
                return -1; // Para indicar error
            }

            cita.IdCita = idActual++;
            listaCitas.Add(cita);
            return cita.IdCita;
        }


        public static void Eliminar(int id)
        {
            var cita = BuscarPorId(id);
            if (cita != null)
            {
                listaCitas.Remove(cita);
            }
        }

    }
}
