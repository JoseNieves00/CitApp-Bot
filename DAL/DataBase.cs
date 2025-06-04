using System;
using System.Data;
using Npgsql;

namespace DAL
{
    public class Database
    {
        protected string ConnectionString = "Host=ep-super-rain-a8q4m9ex-pooler.eastus2.azure.neon.tech;Database=CitApp-DB;Username=CitApp-DB_owner;Password=npg_hgGpPKToC5S7";
        protected NpgsqlConnection  Connection;

        public Database()
        {
            Connection = new NpgsqlConnection (ConnectionString);
        }

        public ConnectionState AbrirConexion()
        {
            try
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
                Connection.Open();
                return Connection.State;
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine($"Error de conexión: {ex.Message}");
                Console.WriteLine($"Código SQLSTATE: {ex.SqlState}");


                if (ex.SqlState == "28P01")
                {
                    Console.WriteLine("Error de autenticación. Verifica usuario y contraseña.");
                }
                else if (ex.SqlState == "3D000")
                {
                    Console.WriteLine("No se pudo acceder a la base de datos especificada.");
                }

                throw;
            }
        }


        public void CerrarConexion()
        {
            Connection.Close();
        }

        public bool TestConexion()
        {
            try
            {
                AbrirConexion();
                CerrarConexion();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}