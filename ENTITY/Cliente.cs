using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public TipoCliente Tipo { get; set; }

        public Cliente() { }

        public Cliente(string nombre, string cedula, TipoCliente tipo)
        {
            Nombre = nombre;
            Cedula = cedula;
            Tipo = tipo;
        }
    }

}
