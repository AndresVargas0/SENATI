using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Final.Interfazes
{
    public partial class Login : Form
    {
        private int indice;

        public Login()
        {
            InitializeComponent();
            indice = 0;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Timer del Reloj
            timer1.Start();
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
            //Timer del Slyder de Imagenes
            timer_img.Start();
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            //Registro de Credenciales de Usuario para Acceso
            string Correo = correo.Text;
            string Contraseña = contraseña.Text;
            string Admin = "Admin";
            string Admin_pass = "admin";
            string Profe = "Profe";
            string Profe_pass = "profe";
            //Funcion para asegurar que los campos esten rellenados
            if (string.IsNullOrEmpty(Correo) || string.IsNullOrEmpty(Contraseña))
            {
                MessageBox.Show("Ingrese su Usuario y Contraseña");
                return;
            }
            //Verificar credenciales del Admin 
            else if (Correo == Admin || Contraseña == Admin_pass)
            {
                this.Hide();
                Admin admin = new Admin();
                admin.Show();
            }
            //Verificar Credenciales del Docente
            else if (Correo == Profe && Contraseña == Profe_pass)
            {
                this.Hide();
                Matricula_Estudiantes matricula = new Matricula_Estudiantes();
                matricula.Show();
            }
            //Mensaje cuando las credenciales son Incorrectas
            else
            {
                MessageBox.Show("Credenciales Incorrectas");
            }
        }
        //Boton Salir
        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Label del Timer de Hora
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        //Funcion para Iterar entre las Imagenes de acuerdo a su Indice
        private void timer_img_Tick(object sender, EventArgs e)
        {
            indice++;
            if (indice > 3)
            {
                indice = 0;
            }
            label2.ImageIndex = indice;
        }
    }
}
