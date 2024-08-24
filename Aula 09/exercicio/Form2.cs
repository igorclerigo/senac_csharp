using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { // Obtem os valores dos TextBoxes
            string nome = textBox1.Text;
            string email = textBox2.Text;
            string salario = textBox3.Text;
            string dataCriacao = DateTime.Now.ToString("yyyy-MM-dd");
            string status = "Ativo";

            string strConexao = "server=localhost;uid=root;database=bancodedados1";
            MySqlConnection conexao = new MySqlConnection(strConexao);

            try
            {
                conexao.Open();

                string query = $"INSERT INTO usuarios (nome, email, DataCriacao, Status) VALUES ('{nome}', '{email}', '{dataCriacao}', '{status}')";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                int linhasAfetadas = cmd.ExecuteNonQuery();


                if (linhasAfetadas > 0)
                {

                    long usuarioID = cmd.LastInsertedId;


                    string querySalario = $"INSERT INTO usuarioperfil (PerfilID, salario) VALUES ('{usuarioID}', '{salario}')";
                    MySqlCommand cmdSalario = new MySqlCommand(querySalario, conexao);
                    cmdSalario.ExecuteNonQuery();

                    MessageBox.Show("Dados inseridos com sucesso!");

                    ClienteCarregador.CarregarClientes(listViewClientes);
                }
                else
                {
                    MessageBox.Show("Falha ao inserir dados.");
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            
            ClienteCarregador.CarregarClientes(listViewClientes);
            LoaderInicial.CarregarLV(listViewClientes);
        }
    }
}


