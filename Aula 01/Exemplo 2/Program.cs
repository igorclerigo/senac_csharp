Console.WriteLine("Exemplo com 'if' e 'else'");
Console.Write("Digite um número: ");

// Declaração direta pois declarei sem antes criar a variável e declarar ela como int
int numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine("O número é positivo.");
}

else
{
    Console.WriteLine("O número não é positivo");
}

Console.ReadKey();


