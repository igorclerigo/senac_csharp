// Exemplo Do - while
// Leitor de número positivo

int numero;

do
{
    Console.Write("Digite um número positivo: ");
    numero = Convert.ToInt32(Console.ReadLine());
}
while (numero <= 0);
Console.WriteLine($"Você digitou o número positivo: {numero}");