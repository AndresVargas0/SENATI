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
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Obtiene los Datos del TextBox
            string nombre = this.nombre.Text;
            string correo = email.Text;
            string pass = this.pass.Text;

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
                        //Muestra las Filas Afectadas
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario creado correctamente");

                            //Cierra la Ventana
                            this.Close();
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

        private void buttoncrear_CLick(object sender, EventArgs e)
        {
            //Inicio inicio = new Inicio;
            //inicio.Show(this);
        }

        private void input_nm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}