// output
Console.WriteLine("Tabuada de X número até 10!");
Console.Write("Informe um valor positivo e inteiro até 10: ");

// input e declaração de variáveis
int numero = Convert.ToInt32(Console.ReadLine());
int tabuada;

// processamento

if (numero > 0 && numero <= 10)
{ 
for (int i = 1; i <= 10; i++)
{
    tabuada = numero * i;
    Console.WriteLine($"{numero} * {i} = {tabuada}");
}

}
else
{
    Console.WriteLine("Você não respeitou as condições impostas pelo sistema!");
}

Console.ReadKey();