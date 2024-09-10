Console.WriteLine("Aula 16 - exercício 2");
Console.WriteLine("Sistemas de opções");



Console.Write("Escola uma opção entre as disponíveis a seguir\n1 - solicitar taxi\n2 - solicitar uber \n3 - solicitar uber moto\n");
Console.Write("\n");
Console.Write("Informe a opção: ");

int opcao = Convert.ToInt32(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.Write("Você solicitou um taxi!");
        break;
    case 2:
        Console.Write("Você solicitou um uber!");
        break;
    case 3:
        Console.Write("Você solicitou um uber moto!");
        break;
    default:
        Console.WriteLine("Você não selecionou uma das opções disponíveis!");
        break;

}

Console.ReadKey();

