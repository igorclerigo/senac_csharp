Console.WriteLine("#### - Exercício 02 - ####");
Console.WriteLine("~ Brincando com as cores ~");
Console.WriteLine("Dicionário \nValor inteiro = cor em Português = cor em Inglês\n1 = verde\n2 = azul\n3 = marrom");
Console.Write("Escolha uma das opções, de 1 até 3: ");
int Valor = Convert.ToInt32(Console.ReadLine());

switch (Valor)
{
    case 1:
        Console.WriteLine("Você selecionou o valor 1, então, farei a tradução da cor verde para inglês é: Green!");
        break;
    case 2:
        Console.WriteLine("Você selecionou o valor 2, então, farei a tradução da cor azul para inglês é: Blue!");
        break;
    case 3:
        Console.WriteLine("Você selecionou o valor 3, então, farei a tradução da cor marrom para inglês é: Brown!");
        break;
    default:
        Console.WriteLine("Você selecionou um valor inválido, então, não farei a tradução!");
        break;

}


Console.ReadKey();
