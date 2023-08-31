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

        private void agregar(string numero)
        {
            if (boxresul.Text == "0")
                boxresul.Text = "";

            boxresul.Text += numero;
        }

        private void buttonCE_CLick(object sender, EventArgs e)
        {
            boxresul.Text += "0";
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            boxresul.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            boxresul.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            boxresul.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            boxresul.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            boxresul.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            boxresul.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            boxresul.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            boxresul.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            boxresul.Text += "9";
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
    }
}