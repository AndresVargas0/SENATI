using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class ConexionDB
    {
        private string servidor = "NXRTH\\SQLEXPRESS";
        private string bd = "Prueba";
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
