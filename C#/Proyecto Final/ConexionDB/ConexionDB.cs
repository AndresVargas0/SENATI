using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Final.ConexionDB
{
    internal class ConexionDB
    {
        private string servidor = "NXRTH\\SQLEXPRESS";
        private string bd = "BD";
        private string usuario = "NXRTH\\Hxruo";
        private SqlConnection conn;

        public ConexionDB()
        {
            string connectionString = $"Data Source={servidor};Initial Catalog={bd};Integrated Security=True;User ID={usuario}";
            conn = new SqlConnection(connectionString);
        }

        public SqlConnection ObtenerConexion()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                return conn;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Fallo en la conexión: " + ex.ToString());
                return null;
            }
        }
    }
}