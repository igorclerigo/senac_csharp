Console.WriteLine("Como está o clima hoje?");
Console.WriteLine("1 - Ensolarado");
Console.WriteLine("2 - Chuvoso");
Console.WriteLine("3 - Nublado");
Console.WriteLine("4 - Nevando");

int clima = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Atividade recomendada:");

switch (clima)
{
    case 1:
        Console.WriteLine("Corrida ao ar livre no parque.");
        break;
    case 2:
        Console.WriteLine("Natação em piscina coberta.");
        break;
    case 3:
        Console.WriteLine("Caminhada leve ou yoga.");
        break;
    case 4:
        Console.WriteLine("Esqui ou exercícios indoor.");
        break;
    default:
        Console.WriteLine("Clima não reconhecido. Que tal uma sessão de alongamento em casa?");
        break;
}