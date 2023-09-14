using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TheArtOfDevHtmlRenderer.Adapters;
using Proyecto_Final.ConexionDB;

namespace Proyecto_Final
{
    public partial class CRUD_Estudiantes : Form
    {
        public CRUD_Estudiantes()
        {
            InitializeComponent();
        }

        private void CRUD_Estudiantes_Load(object sender, EventArgs e)
        {

        }

        private void matricular_Click(object sender, EventArgs e)
        {
            string Nombre = TextBox1.Text;
            string Apellido = TextBox2.Text;
            string Apoderado = TextBox3.Text;
            string Dni = TextBox4.Text;
            string Telefono = TextBox5.Text;
            string Grado = ComboBox2.Text;
            string Seccion = ComboBox1.Text;

            if (string.IsNullOrEmpty(Nombre)||
                string.IsNullOrEmpty(Apellido)||
                string.IsNullOrEmpty(Dni)||
                string.IsNullOrEmpty(Apoderado)||
                string.IsNullOrEmpty(Telefono)||
                string.IsNullOrEmpty(Grado)||
                string.IsNullOrEmpty(Seccion))
            {
                MessageBox.Show("Algunos Campos no Fueron Rellenados");
            }

            ConexionDB.ConexionDB conexion = new ConexionDB.ConexionDB();
            SqlConnection conn = conexion.ObtenerConexion();

            if (conn != null)
            {
                try
                {
                    //Insertar Datos
                    string query = "INSERT INTO Estudiantes_Matriculados (Nombre,Apellido,Apoderado,Dni,Telefono,Grado,Seccion) VALUES (@Nombre,@Apellido,@Apoderado,@Dni,@Telefono,@Grado,@Seccion)";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        //Parametros a usar en la Consulta
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Apellido", Apellido);
                        command.Parameters.AddWithValue("@Apoderado", Apoderado);
                        command.Parameters.AddWithValue("@Dni", Dni);
                        command.Parameters.AddWithValue("@Telefono", Telefono);
                        command.Parameters.AddWithValue("@Grado", Grado);
                        command.Parameters.AddWithValue("@Seccion", Seccion);


                        //Muestra las Filas Afectadas
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Estudiante Registrado Correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se Pudo Registrar al Alumno");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    //Cierra la Conexion
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Error en la conexión a la base de datos.");
            }
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void apoderado_TextChanged(object sender, EventArgs e)
        {

        }

        private void dni_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
