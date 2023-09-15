using System;
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
            // TODO: esta línea de código carga datos en la tabla 'bDDataSet.Estudiantes_Matriculados' Puede moverla o quitarla según sea necesario.
            this.estudiantes_MatriculadosTableAdapter.Fill(this.bDDataSet.Estudiantes_Matriculados);
        }

        private void eliminar_Click(object sender, EventArgs e)
        {

        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            String Nombre = TextBox1.Text;
            String Apellido = TextBox2.Text;
            String Apoderado = TextBox3.Text;
            String Dni = TextBox4.Text;
            String Grado = ComboBox2.Text;
            String Seccion = ComboBox1.Text;

            ConexionDB.ConexionDB conexion = new ConexionDB.ConexionDB();
            SqlConnection conn = conexion.ObtenerConexion();
            conn.Open();

            try
            {
                string sql = "UPDATE MiTabla SET Grado = @Grado, Seccion = @Seccion WHERE DNI = @Dni;";
                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.AddWithValue("@DNI", Dni);
                command.Parameters.AddWithValue("@Grado", Grado);
                command.Parameters.AddWithValue("@Seccion", Seccion);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registro actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("Ningún registro actualizado. Puede que el ID no exista.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
