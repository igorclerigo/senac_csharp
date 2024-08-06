Console.WriteLine("##################");
Console.WriteLine("- EXERCÍCIO 02 -");
Console.WriteLine("##################");
Console.Write("Digite um número: ");

// Declaração direta pois declarei sem antes criar a variável e declarar ela como int
// Para declaração separadamente, é só colocar o tipo e depois o nome da variável. ex: int numero;
// O ReadLine é pra ler o input do usuário
int numero = Convert.ToInt32(Console.ReadLine());


if (numero % 3 == 0)
{
    numero = numero * 5;
    Console.WriteLine($"O número é divisível por 3, então, o quíntoplu de número é {numero}!");
    // posso fazer concatenando também ex: Console.WriteLine("O número é divisível por 3, então, o quíntoplu de número é:" + numero);
}

else
{
    numero = numero * 3;
    Console.WriteLine($"O número não é divisível por 3, então, o seu triplo é {numero}!");
}

Console.ReadKey();

