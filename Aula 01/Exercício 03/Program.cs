using System.ComponentModel.Design;

Console.WriteLine("##################");
Console.WriteLine("- EXERCÍCIO 03 -");
Console.WriteLine("##################");

Console.WriteLine("RPG - SELEÇÃO DE PERSONAGEM");
Console.Write("Escolha uma das opções, de 1 até 4: ");
int numero = Convert.ToInt32(Console.ReadLine());


if (numero  == 1)
{
    Console.WriteLine($"Você selecionou a opção {numero}, portanto, Você será um Bardo!");
}

else if (numero == 2)
{

    Console.WriteLine($"Você selecionou a opção {numero}, portanto, Você será um Arqueiro!");
}

else if (numero == 3)
{
    Console.WriteLine($"Você selecionou a opção {numero}, portanto, Você será um Guerreiro!");
}

else if (numero == 4)
{
    Console.WriteLine($"Você selecionou a opção {numero}, portanto, Você será um Mago!");
}

else
{
    Console.WriteLine("Você informou um número inválido. Por favor, infome um número de 1 até 4.");
}

Console.ReadKey();



// resolução do professor abaixo
Console.Write("Digite A Classe desejada: \n 1- Bardo \n 2- arqueiro \n 3- arqueiro \n 4- mago \n");
int selecao = Convert.ToInt32(Console.ReadLine());

if (selecao == 1)
{
    Console.WriteLine("Você selecionou Bardo" + " ao escolher opção: " + selecao);
}
else if (selecao == 2)
{
    Console.WriteLine("Você selecionou arqueiro" + " ao escolher opção: " + selecao);
}
else if (selecao == 3)
{
    Console.WriteLine("Você selecionou guerreiro" + " ao escolher opção: " + selecao);
}
else if (selecao == 4)
{
    Console.WriteLine("Você selecionou mago" + " ao escolher opção: " + selecao);
}
else
{
    Console.WriteLine("Opção invalida");
}
Console.ReadKey();
