using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Login;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Configuracion Ventana
                this.StartPosition = FormStartPosition.CenterScreen;
                this.MaximizeBox = false;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.Text = "Crear Cuenta";
            }
            catch (Exception ex)
            {
                //Registra las Excepciones
                Console.WriteLine("Excepción en FormCrear_Load: " + ex.Message);
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Obtiene los Datos del TextBox
            string nombre = input_nm.Text;
            string correo = input_email.Text;
            string pass = input_pw1.Text;

            //Verifica Campos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            //Conexion
            ConexionDB conexion = new ConexionDB();

            SqlConnection conn = conexion.ObtenerConexion();

            if (conn != null)
            {
                try
                {
                    //Insertar Datos
                    string query = "INSERT INTO Login (Nombre,Email,Pass) VALUES (@Nombre, @Correo, @Pass)";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        //Parametros
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.Parameters.AddWithValue("@Pass", pass);

                        //Realiza la consulta
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario creado correctamente");

                            //Cierra la Ventana
                            this.Hide();

                            //Reabre la Ventana de Registro
                            Form1 login = new Form1();
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo crear usuario");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar datos: " + ex.Message);
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
    }
}