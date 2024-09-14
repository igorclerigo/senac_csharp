using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        Console.Write("Digite o nome ou número do Pokémon: ");
        string pokemon = Console.ReadLine()?.ToLower();

        try
        {
            string respostaPokemon = await ObterDadosPokemon(pokemon);
            Console.WriteLine(respostaPokemon);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao obter dados do Pokémon: {ex.Message}");
        }
    }

    static async Task<string> ObterDadosPokemon(string pokemon)
    {
        using (HttpClient client = new HttpClient())
        {
            string apiUrl = $"https://pokeapi.co/api/v2/pokemon/{pokemon}";
            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseBody);

                string nome = json["name"].ToString();
                string altura = json["height"].ToString();
                string peso = json["weight"].ToString();
                string tipo = json["types"][0]["type"]["name"].ToString();
                string exp = json["base_experience"].ToString();
                string ordem = json["order"].ToString();
                string id = json["id"].ToString();
                



                return $"Pokémon: {nome}\nAltura: {altura} dm\nPeso: {peso} hg\nTipo: {tipo}\nExperîência base: {exp}\nOrdem: {ordem}\nID do Pokemón: {id}";
            }
            else
            {
                throw new Exception("Não foi possível obter os dados do Pokémon.");
            }
        }
    }
}