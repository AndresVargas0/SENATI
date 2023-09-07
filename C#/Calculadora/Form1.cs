namespace Calculadora
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool unnumero = false;
        double a;
        double b;
        string c;

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
            if (this.boxresul.Text.Contains('.') == false)
            {
                this.boxresul.Text = this.boxresul.Text + ".";
            }
        }

        private void buttonmas_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.boxresul.Text);
            c = "+";
            this.boxresul.Clear();
            this.boxresul.Focus();
        }

        private void buttonmenos_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.boxresul.Text);
            c = "-";
            this.boxresul.Clear();
            this.boxresul.Focus();
        }

        private void buttonmul_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.boxresul.Text);
            c = "*";
            this.boxresul.Clear();
            this.boxresul.Focus();
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.boxresul.Text);
            c = "/";
            this.boxresul.Clear();
            this.boxresul.Focus();
        }

        private void buttonigual_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(this.boxresul.Text);
            switch (c)
            {
                case "+":
                    this.boxresul.Text = Convert.ToString(b + a);
                    break;

                case "-":
                    this.boxresul.Text = Convert.ToString(b - a);
                    break;

                case "*":
                    this.boxresul.Text = Convert.ToString(b * a);
                    break;

                case "/":
                    this.boxresul.Text = Convert.ToString(b / a);
                    break;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}