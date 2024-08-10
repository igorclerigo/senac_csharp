namespace Exemplo_1___forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int soma = numero1 + numero2;
            label1.Text = "Soma: " + soma.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int subt = numero1 - numero2;
            label1.Text = "Subtração: " + subt.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int multi = numero1 * numero2;
            label1.Text = "Multiplicação: " + multi.ToString();
        }
    }
}