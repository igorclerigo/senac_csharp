using System.Net.Http.Json;


// Define o modelo do pedido
public class produto
{
    public int Id { get; set; }
    public float Valor { get; set; }
    public int Quantidade { get; set; }
    public string Nomeproduto { get; set; }

}

class Program
{
    static async Task Main(string[] args)
    {
        // URL da API (ajuste conforme o endereço da API)
        string apiUrl = "https://localhost:7015/api/produtocontrolador";

        Console.Write("Digite o nome do produto: ");
        string nomeproduto = Console.ReadLine();

        // Solicita informações do pedido ao usuário
        Console.Write("Digite o valor do produto: ");
        float valor = float.Parse(Console.ReadLine());

        while (valor <= 10)
        {
            Console.WriteLine("Somente são aceitos pedidos acima de R$ 10,00! Requisição não enviada!");
            Console.Write("Digite o valor do produto: ");
            valor = float.Parse(Console.ReadLine());

        }


        Console.Write("Digite a quantidade desejada: ");
        int quantidade = int.Parse(Console.ReadLine());



        // Cria um novo pedido
        produto novoproduto = new produto
        {
            Nomeproduto = nomeproduto,
            Quantidade = quantidade,
            Valor = valor
        };

        // Envia o pedido para a API
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(apiUrl, novoproduto);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Pedido enviado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao enviar o pedido.");
            }
        }
        Console.ReadKey();
    }
}

