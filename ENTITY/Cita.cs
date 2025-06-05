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
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Estado { get; set; }

        public Cita() { }

        public Cita(int idCita, Paciente paciente, Medico medico, DateTime fecha, TimeSpan hora, string estado)
        {
            IdCita = idCita;
            Paciente = paciente;
            Medico = medico;
            Fecha = fecha;
            Hora = hora;
            Estado = estado;
        }
    }
}
