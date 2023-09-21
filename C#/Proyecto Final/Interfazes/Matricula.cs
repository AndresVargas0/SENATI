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

        public void CRUD_Estudiantes_Load(object sender, EventArgs e)
        {
            
        }

        private void matricular_Click(object sender, EventArgs e)
        {
            //Variables a Usar
            string Nombre = TextBox1.Text;
            string Apellido = TextBox2.Text;
            string Apoderado = TextBox3.Text;
            string Dni = TextBox4.Text;
            string Telefono = TextBox5.Text;
            string Grado = ComboBox2.Text;
            string Seccion = ComboBox1.Text;
            //Funcion para Asegurar que lo Campos esten rellenados
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
            //Conexion DB
            ConexionDB.ConexionDB conexion = new ConexionDB.ConexionDB();
            SqlConnection conn = conexion.ObtenerConexion();
                try
                {
                    //Consulta para Insertar los Datos de las Variables a la tabla en la BD
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
                        //Verificar Cambios en la Tabla
                        int rowsAffected = command.ExecuteNonQuery();
                        //Mensajes de Confirmacion o Error
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
                //Error Adicional
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                //Cierra la Conexion
                finally
                {
                    conn.Close();
                }
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            //Cerrar Ventana y Regresar al Login
            this.Hide();
            Login login = new Login();
            login.Show();
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