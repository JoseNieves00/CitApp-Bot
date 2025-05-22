using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public class ClienteBLL
    {
        public static bool RegistrarCliente(Cliente cliente)
        {
            if (ClienteDAL.BuscarPorCedula(cliente.Cedula) == null)
            {
                ClienteDAL.AgregarCliente(cliente);
                return true;
            }
            return false; // Ya existe
        }

        public static Cliente ObtenerCliente(string cedula)
        {
            return ClienteDAL.BuscarPorCedula(cedula);
        }
    }
}

