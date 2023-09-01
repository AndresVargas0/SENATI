namespace Calculadora
{
    public partial class Form1 : Form
    {
        double n1 = 0;
        double n2 = 0;
        bool unnumero = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LeerNumero(string numero)
        {
            unnumero = true;
            if (boxresul.Text == "0" && boxresul.Text != null)
            {
                boxresul.Text = numero;
            }
            else
            {
                boxresul.Text += numero;
            }
        }

        private void buttonCE_CLick(object sender, EventArgs e)
        {
            boxresul.Text += "0";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LeerNumero("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LeerNumero("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            LeerNumero("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (boxresul.Text == "0")
            {
                return;
            }
            else
            {
                boxresul.Text += "0";
            }
        }

        private void buttonCE_Click_1(object sender, EventArgs e)
        {
            if (boxresul.Text != "0")
            {
                boxresul.Text = "0";
            }
        }

        private void buttonpunto_Click(object sender, EventArgs e)
        {
            LeerNumero(buttonpunto.Text);
        }

        private void buttonmas_Click(object sender, EventArgs e)
        {
            
        }
    }
}