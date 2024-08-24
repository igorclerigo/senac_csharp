﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio
{
    public class ClienteCarregador
    {
        public static void CarregarClientes(ListView listViewClientes)
        {
            // Definir a string de conexão ao banco de dados
            string strConexao = "server=localhost;uid=root;database=bancodedados1";
            MySqlConnection conexao = new MySqlConnection(strConexao);

            try
            {
                conexao.Open();

                // Query SQL para selecionar todos os campos da tabela 'usuarios'
                string query = "SELECT u.UsuarioID, u.nome, u.idade, up.salario, u.email, u.DataCriacao, \r\nStatus FROM usuarios as u JOIN usuarioperfil as up ON u.UsuarioID = up.PerfilID";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Limpa os itens existentes no ListView antes de recarregar
                listViewClientes.Items.Clear();

                // Itera sobre os dados e os adiciona ao ListView
                while (reader.Read())
                {
                    // Cria um novo item no ListView com o 'UsuarioID' como primeira coluna
                    ListViewItem item = new ListViewItem(reader["UsuarioID"].ToString());

                    // Adiciona os outros campos como subitens
                    item.SubItems.Add(reader["nome"].ToString());
                    item.SubItems.Add(reader["salario"].ToString());
                    item.SubItems.Add(reader["idade"].ToString());
                    item.SubItems.Add(reader["email"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["DataCriacao"]).ToString("dd/MM/yyyy")); // Formata a Data de Criação
                    item.SubItems.Add(reader["Status"].ToString());

                    // Adiciona o item ao ListView
                    listViewClientes.Items.Add(item);
                }

                // Fecha o reader e a conexão
                reader.Close();
                conexao.Close();
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro se algo der errado
                MessageBox.Show($"Erro ao carregar usuários: {ex.Message}");
            }
        }
    }

    public class LoaderInicial
    {
        public static void CarregarLV(ListView listViewClientes)
        {
            listViewClientes.View = View.Details;
            listViewClientes.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Idade", 50, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Email", 200, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("DataCriacao", 130, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Status", 100, HorizontalAlignment.Left);
            listViewClientes.Columns.Add("Salario", 70, HorizontalAlignment.Left);
            listViewClientes.FullRowSelect = true; // Ativa a seleção da linha toda
            listViewClientes.GridLines = true; // Adiciona linhas de grade para melhor visualização
                                               // Carrega os usuarioss na ListView
            ClienteCarregador.CarregarClientes(listViewClientes);
        }


    }




}