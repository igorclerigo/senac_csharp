Console.WriteLine("Exemplo com 'if' e 'else': ");

// A diferença entre Write e WriteLine é o que o Write pula linha
Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("O número é par.");

}
else
{
    Console.WriteLine("O número é ímpar.");
}

//Mantém a janela do console aberta
Console.ReadKey();