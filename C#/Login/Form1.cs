namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Email = "andres";
        string Pass = "1234";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void correo(String correo)
        {
            if (email.Text == Email)
            {
                email.Text = correo;
            }
        }

        private void contra(String contra)
        {
            if (pass.Text == Pass)
            {
                pass.Text = contra;
            }
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            if (correo == correo)
            {
                Form2 form2 = new Form2();
                form2.Show(this);
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            correo(email.Text);
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            contra(pass.Text);
        }
    }
}