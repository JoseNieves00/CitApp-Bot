using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cita
    {
        public int IdCita { get; set; }
        public Cliente Cliente { get; set; }
        public Medico Medico { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; } // "06:00", "07:27", etc.
        public decimal Valor { get; set; }
        public string Estado { get; set; } // "Agendada", "Realizada", "Cancelada"

        public Cita() { }

        public Cita(int idCita, Cliente cliente, Medico medico, DateTime fecha, TimeSpan hora, decimal valor, string estado)
        {
            IdCita = idCita;
            Cliente = cliente;
            Medico = medico;
            Fecha = fecha;
            Hora = hora;
            Valor = valor;
            Estado = estado;
        }
    }
}
