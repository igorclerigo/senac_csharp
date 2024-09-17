using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;


// CONSUMINDO SpaceX API
class Program
{
    static async Task Main(string[] args)
    {
        Console.Write("Digite o nome da rota desejada: ");
        string rota = Console.ReadLine()?.ToLower();

        try
        {
            string respostaRota = await ObterDadosSpaceX(rota);
            Console.WriteLine(respostaRota);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao obter dados da rota: {ex.Message}");
        }
    }

    static async Task<string> ObterDadosSpaceX(string rota)
    {
        using (HttpClient client = new HttpClient())
        {
            string apiUrl = "https://api.spacexdata.com/v5/launches/latest";
            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseBody);

                string nome = json["cores"].ToString();



                return $"Rota: {nome}";
            }
            else
            {
                throw new Exception("Não foi possível obter os dados da rota.");
            }
        }
    }
}