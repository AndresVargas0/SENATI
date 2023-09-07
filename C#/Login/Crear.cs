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
    public partial class Crear : Form
    {
        public Crear()
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
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {}

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Obtiene los Datos del TextBox
            string nombre = this.textBox1.Text;
            string correo = textBox2.Text;
            string pass = this.textBox3.Text;

            //Verifica Campos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Faltan Campos por Rellenar");
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

                        // Parametros para evitar inyecciones sql
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.Parameters.AddWithValue("@Pass", pass);

                        //Muestra las Filas Afectadas
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario creado correctamente");

                            //Cierra la Ventana
                            this.Hide();
                            Registrar registrar = new Registrar();
                            registrar.Show(this);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrar registrar = new Registrar();
            registrar.Show(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {}
    }
}