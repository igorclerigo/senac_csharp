Console.WriteLine("Exemplo com 'else if'");

Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());


if (numero > 0)
{
    
    Console.WriteLine("O número é positivo.");
}

else if (numero == 0)
{
  
    Console.WriteLine("O número é zero.");
}

else
{
    Console.WriteLine("O número não é positivo.");
}

Console.ReadKey();