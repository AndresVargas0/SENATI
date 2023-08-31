using System.Drawing.Text;

namespace Calculadora
{
    public enum operacion
    {
        nodefinida = 0,
        suma = 1,
        resta = 2,
        division = 3,
        multiplicacion = 4,
        modulo = 5
    }

    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        operacion operador = operacion.nodefinida;

        public Form1()
        {
            InitializeComponent();
        }

        private void LeerNumero(string numero)
        {
            if (BoxResul.Text == "0" && BoxResul.Text != null)
            {
                BoxResul.Text = numero;
            }
            else
            {
                BoxResul.Text += numero;
            }
        }

        private double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operador)
            {
                case operacion.suma:
                    resultado = valor1 + valor2;
                    break;
                case operacion.resta:
                    resultado = valor1 - valor2;
                    break;
                case operacion.division:
                    if (valor2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre 0");
                        resultado = 0;
                    }
                    break;
                case operacion.multiplicacion:
                    resultado = valor1 * valor2;
                    break;
                case operacion.modulo:
                    resultado = valor1 % valor2;
                    break;
            }
            return resultado;

            private void Button0_CLick(object sender, EventArgs e)
            {
                if (BoxResul.Text == "0")
                {
                    return;
                }
                else
                {
                    BoxResul.Text += "0";
                }
            }

            private void Button1_CLick(object sender, EventArgs e)
            {
                LeerNumero("1");
            }

            private void Button2_CLick(object sender, EventArgs e)
            {
                LeerNumero("2");
            }

            private void Button3_Click(object sender, EventArgs e)
            {
                LeerNumero("3");
            }

            private void Button4_Click(object sender, EventArgs e)
            {
                LeerNumero("4");
            }

            private void Button5_Click(object sender, EventArgs e)
            {
                LeerNumero("5");
            }

            private void Button6_Click(object sender, EventArgs e)
            {
                LeerNumero("6");
            }

            private void Button7_Click(object sender, EventArgs e)
            {
                LeerNumero("7");
            }

            private void Button3_Click(object sender, EventArgs e)
            {
                LeerNumero("3");
            }



            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void Form1_Load_1(object sender, EventArgs e)
            {

            }

        }