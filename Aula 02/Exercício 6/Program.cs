Console.Write("Informe um número inteiro e positivo: ");
int y = Convert.ToInt32(Console.ReadLine());
int x = 1;

    for (int i = 1; i <= y; i++)
    {
        x = x * i;
    /* faz o fatorial do valor da variável y
     5 5*4*3*2*1
     5*1 = 5
     5*2 = 10
     10*3 = 30
     30*4 = 120
    */
    }


Console.WriteLine(x);
Console.ReadKey();