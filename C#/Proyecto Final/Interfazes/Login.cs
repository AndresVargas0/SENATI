using System;
using System.Windows.Forms;

namespace Proyecto_Final.Interfazes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            String Correo = correo.Text;
            String Contraseña = contraseña.Text;
            String Admin = "Admin";
            String Admin_pass = "admin";
            String Profe = "Profe1";
            String Profe_pass = "profe1";

            if (Correo == Admin && Contraseña == Admin_pass)
            {
                this.Hide();
                Admin admin = new Admin();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Error (Datos Incorrectos)");
            }

            if (Correo == Profe && Contraseña == Profe_pass)
            {
                this.Hide();
                Matricula_Estudiantes matricula = new Matricula_Estudiantes();
                matricula.Show();
            }
            else
            {
                MessageBox.Show("Error (Datos Incorrectos)");
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
