using System.ComponentModel.Design;

Console.WriteLine("##################");
Console.WriteLine("- EXERCÍCIO 01 -");
Console.WriteLine("##################");

Console.WriteLine("RPG - SELEÇÃO DE PERSONAGEM");
Console.Write("Escolha uma das opções, de 1 até 4: ");
int numero = Convert.ToInt32(Console.ReadLine());


switch (numero)
{
    case 1:
        Console.WriteLine($"Você selecionou a opção {numero}, portanto, Você será um Bardo!");
        break;

    case 2:
        Console.WriteLine($"Você selecionou a opção {numero}, portanto, Você será um Arqueiro!");
        break;
    case 3:
        Console.WriteLine($"Você selecionou a opção {numero}, portanto, Você será um Guerreiro!");
        break;
    case 4:
        Console.WriteLine($"Você selecionou a opção {numero}, portanto, Você será um Mago!");
        break;
    default:
        Console.WriteLine("Você informou um número inválido. Por favor, infome um número de 1 até 4.");
        break;
}

Console.ReadKey();