using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Final.Interfazes
{
    public partial class Matricula_Estudiantes : Form
    {
        public Matricula_Estudiantes()
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

            if (string.IsNullOrEmpty(Nombre) ||
                string.IsNullOrEmpty(Apellido) ||
                string.IsNullOrEmpty(Dni) ||
                string.IsNullOrEmpty(Apoderado) ||
                string.IsNullOrEmpty(Telefono) ||
                string.IsNullOrEmpty(Grado) ||
                string.IsNullOrEmpty(Seccion))
            {
                MessageBox.Show("Algunos Campos no Fueron Rellenados");
                return;
            }
            else
            {
                ConexionDB.ConexionDB conexion = new ConexionDB.ConexionDB();
                SqlConnection conn = conexion.ObtenerConexion();

                if (conn != null)
                {
                    try
                    {
                        string query = "INSERT INTO Estudiantes_Matriculados (Nombre,Apellido,Apoderado,Dni,Telefono,Grado,Seccion) VALUES (@Nombre,@Apellido,@Apoderado,@Dni,@Telefono,@Grado,@Seccion)";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@Nombre", Nombre);
                            command.Parameters.AddWithValue("@Apellido", Apellido);
                            command.Parameters.AddWithValue("@Apoderado", Apoderado);
                            command.Parameters.AddWithValue("@Dni", Dni);
                            command.Parameters.AddWithValue("@Telefono", Telefono);
                            command.Parameters.AddWithValue("@Grado", Grado);
                            command.Parameters.AddWithValue("@Seccion", Seccion);

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
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error en la conexión a la base de datos.");
                }
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}