Console.Write("Informe um número inteiro: ");
int y = Convert.ToInt32(Console.ReadLine());
int x = 0;

for (int i = 1; i <= y; i++)
{
    x = x + i;
       
}

Console.WriteLine(x);
Console.ReadKey();