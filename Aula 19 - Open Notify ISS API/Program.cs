using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;


// CONSUMINDO Open Notify API
class Program
{
    static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            string apiUrl = "http://api.open-notify.org/iss-now.json";

            try
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseBody);

                var latitude = json["iss_position"]["latitude"];
                var longitude = json["iss_position"]["longitude"];

                // Exibe os dados
                Console.WriteLine($"Latitude: {latitude}");
                Console.WriteLine($"Longitude: {longitude}");


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter dados da rota: {ex.Message}");
            }
        }

    }

}