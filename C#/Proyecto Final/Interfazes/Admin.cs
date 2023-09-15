using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            this.estudiantes_MatriculadosTableAdapter.Fill(this.bDDataSet.Estudiantes_Matriculados);
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            String Dni = TextBox4.Text;

            ConexionDB.ConexionDB conexion = new ConexionDB.ConexionDB();
            SqlConnection conn = conexion.ObtenerConexion();
            conn.Open();

            try
            {
                string delete = "DELETE FROM Estudiantes_Mattriculados WHERE Dni = @Dni;";
                SqlCommand command = new SqlCommand(delete, conn);

                command.Parameters.AddWithValue("@Dni", Dni);

                int rowsAffected = command.ExecuteNonQuery();

                DataTable datatable = new DataTable();
                estudiantesMatriculadosBindingSource.DataSource = datatable;

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
            String Dni = TextBox4.Text;
            String Grado = ComboBox2.Text;
            String Seccion = ComboBox1.Text;

            ConexionDB.ConexionDB conexion = new ConexionDB.ConexionDB();
            SqlConnection conn = conexion.ObtenerConexion();
            conn.Open();

            try
            {
                string update = "UPDATE Estudiantes_Matriculados SET Grado = @Grado, Seccion = @Seccion WHERE DNI = @Dni";
                string actualizar = "SELECT * FROM Estudiantes_Matriculados";
                SqlCommand command = new SqlCommand(update, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(actualizar, conn);

                command.Parameters.AddWithValue("@DNI", Dni);
                command.Parameters.AddWithValue("@Grado", Grado);
                command.Parameters.AddWithValue("@Seccion", Seccion);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Informacion del Alumno Actualizada Correctamente.");
                }
                else
                {
                    MessageBox.Show("Error, Datos Incorrectos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar: " + ex.Message);
            }
            finally
            {
                conn.Close();
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
                    finally
                    {
                        conn.Close();
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
    }
}
