// Leitor de número inteiro

Console.Write("Digite um número inteiro: ");
double numero = Convert.ToDouble(Console.ReadLine());
int numero2 = (int)numero;

if (numero == numero2)
{
    Console.Write("O número é inteiro");
}
else
{
    Console.Write("O número não é inteiro");
}

Console.ReadKey();
