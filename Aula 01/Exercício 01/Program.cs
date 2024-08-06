Console.WriteLine("##################");
Console.WriteLine("- EXERCÍCIO 01 -");
Console.WriteLine("##################");

Console.Write("Digite o primeiro valor: ");
int PrimeiroValor = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o segundo valor: ");
int SegundoValor = Convert.ToInt32(Console.ReadLine());

int soma = PrimeiroValor + SegundoValor;

if (soma > 70)
{
    Console.WriteLine("Financiamento Aprovado");
}

else
{
    Console.WriteLine("Financiamento Reprovado");
}

Console.ReadKey();


