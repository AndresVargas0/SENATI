using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace Proyecto_Final.Interfazes
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            String Dni = TextBox4.Text;

            ConexionDB.ConexionDB conexion = new ConexionDB.ConexionDB();
            SqlConnection conn = conexion.ObtenerConexion();

            try
            {
                string delete = "DELETE FROM Estudiantes_Matriculados WHERE Dni = @Dni;";
                SqlCommand command = new SqlCommand(delete, conn);

                command.Parameters.AddWithValue("@Dni", Dni);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Estudiante Eliminado");
                }
                else
                {
                    MessageBox.Show("Error, ese estudiante no Existe en la BD");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar: " + ex.Message);
            }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            ConexionDB.ConexionDB conexion = new ConexionDB.ConexionDB();
            SqlConnection conn = conexion.ObtenerConexion();

            tabla.DataSource = null;

            string selectQuery = "SELECT * FROM Estudiantes_Matriculados";
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    tabla.DataSource = dataTable;
                }
            }
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
                }
            }
        }



        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void estudiantesMatriculadosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
