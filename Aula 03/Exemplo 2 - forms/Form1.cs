namespace Exemplo_2___forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto1 = textBox1.Text;
            string texto2 = textBox2.Text;
            if (texto1 == texto2)
            {
                label1.Text = "As strings são iguais";
            }
            else
            {
                label1.Text = "As strings sao diferentes";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}