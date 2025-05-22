using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class ClienteDAL
    {
        private static List<Cliente> listaClientes = new List<Cliente>();

        public static void AgregarCliente(Cliente cliente)
        {
            listaClientes.Add(cliente);
        }

        public static List<Cliente> ListarClientes()
        {
            return listaClientes;
        }

        public static Cliente BuscarPorCedula(string cedula)
        {
            return listaClientes.FirstOrDefault(c => c.Cedula == cedula);
        }
    }
}
