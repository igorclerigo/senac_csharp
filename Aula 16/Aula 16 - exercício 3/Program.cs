using System.Net.Http.Json;


public class Tarefa
    {
    public int Id { get; set; }
    public string Titulo { get; set; }
    public bool Concluida { get; set; }
}

class Program
{
    static async Task Main(string[] args)
    {
        // URL da API (ajuste conforme o endereço da API)
        string apiUrl = "https://localhost:7236/api/Tarefas";


        // Solicita informações do pedido ao usuário

        Console.Write("Digite o título da tarefa: ");
        string nome = Console.ReadLine();

        
        bool status = false;
        Console.Write("Digite o status - concluída (sim/não) ");
        string resposta = Console.ReadLine().ToLower();

        if (resposta == "sim")
        {
            status = true;
        }


        // Cria um novo pedido
        Tarefa novaTarefa = new Tarefa
        {
            Titulo = nome,
            Concluida = status
        };

        // Envia o pedido para a API
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(apiUrl, novaTarefa);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Pedido enviado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao enviar o pedido.");
            }
        }
    }
}