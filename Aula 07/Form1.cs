using MySql.Data.MySqlClient;

namespace Aula_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var strConexao = "server=localhost;uid=root;database=bancodedados1";
            var conexao = new MySqlConnection(strConexao);
            conexao.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listViewClientes.View = View.Details;
            listViewClientes.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Email", 200, HorizontalAlignment.Left);
            listViewClientes.FullRowSelect = true; // Ativa a sele��o da linha toda
            listViewClientes.GridLines = true; // Adiciona linhas de grade para melhor visualiza��o
                                               // Carrega os usuarioss na ListView
            CarregarClientes();
        }
        private void CarregarClientes()
        {
            string strConexao = "server=localhost;uid=root;database=bancodedados1";
            MySqlConnection conexao = new MySqlConnection(strConexao);

            try
            {
                conexao.Open();

                // Query SQL para selecionar todos os registros da tabela 'usuarios'
                string query = "SELECT UsuarioID, nome, email, Status FROM usuarios";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Limpa os itens existentes no ListView antes de recarregar
                listViewClientes.Items.Clear();

                // Itera sobre os dados e os adiciona ao ListView
                while (reader.Read())
                {
                    // Adiciona os itens ao ListView
                    ListViewItem item = new ListViewItem(reader["UsuarioID"].ToString());
                    item.SubItems.Add(reader["nome"].ToString());
                    item.SubItems.Add(reader["email"].ToString());
                    listViewClientes.Items.Add(item);
                }

                reader.Close();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar usuarioss: {ex.Message}");
            }
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
        {
            // Obtem os valores dos TextBoxes
            string nome = textBox1.Text;
            string email = textBox2.Text;
            string dataCriacao = DateTime.Now.ToString("yyyy-MM-dd");
            string status = "Ativo";

            string strConexao = "server=localhost;uid=root;database=bancodedados1";
            MySqlConnection conexao = new MySqlConnection(strConexao);

            try
            {
                conexao.Open();

                // Query SQL para inser��o de dados na tabela 'usuarios'
                string query = $"INSERT INTO usuarios (nome, email, DataCriacao, Status) VALUES ('{nome}', '{email}', '{dataCriacao}', '{status}')";

                MySqlCommand cmd = new MySqlCommand(query, conexao);

                // Executa o comando de inser��o
                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Dados inseridos com sucesso!");
                    // Ap�s inser��o, atualiza a ListView
                    CarregarClientes();
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Verifica se h� algum item selecionado no ListView
            if (listViewClientes.SelectedItems.Count > 0)
            {
                // Pega o ID do usuarios selecionado (primeira coluna do ListView)
                string UsuarioID = listViewClientes.SelectedItems[0].SubItems[0].Text;

                string strConexao = "server=localhost;uid=root;database=bancodedados1";
                MySqlConnection conexao = new MySqlConnection(strConexao);

                try
                {
                    conexao.Open();

                    // Query SQL para deletar o usuarios baseado no UsuarioID
                    string query = $"DELETE FROM usuarios WHERE UsuarioID = {UsuarioID}";

                    MySqlCommand cmd = new MySqlCommand(query, conexao);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    // Verifica se o registro foi exclu�do com sucesso
                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Cliente exclu�do com sucesso!");
                        // Atualiza o ListView ap�s a exclus�o
                        CarregarClientes();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao excluir o usuarios.");
                    }

                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir o usuarios: {ex.Message}");
                }
            }
            else
            {
                // Exibe uma mensagem caso nenhum usuarios tenha sido selecionado
                MessageBox.Show("Por favor, selecione um usuarios para excluir.");
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            // Exibe o form2 como uma nova janela
            form2.Show();
        }
    }
}