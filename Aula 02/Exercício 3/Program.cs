Console.WriteLine("#### - Exercício 03 - ####");
Console.WriteLine("~ App de música para conversão de notas musicais ~");
Console.Write("Opções:");
Console.WriteLine("\n1 - C4 (Dó4)\n2 - D4 (Ré4)\n3 - E4 (Mi4)\n4 - F4 (Fá4) ");
Console.Write("Escolha uma das opções de 1 até 4:");
int Opcao = Convert.ToInt32(Console.ReadLine());
string Pergunta;

switch (Opcao)
{
    case 1:
        Console.WriteLine("Frequência: 261.63 Hz.");
        Console.WriteLine("Você gostaria de saber a frequência corresponde em sustenido?");
        Pergunta = Console.ReadLine();
        if (Pergunta == "sim")
        {
            Console.WriteLine("O C4 (Dó4) em sustenido possui a frequência de 277.18 Hz.");
        }
        else
        { Console.WriteLine("A frequência permanece em 261.63 Hz."); 
        }
        break;
    case 2:
        Console.WriteLine("Frequência: 293.66 Hz.");
        Console.WriteLine("Você gostaria de saber a frequência corresponde em sustenido?");
        Pergunta = Console.ReadLine();
        if (Pergunta == "sim")
        {
            Console.WriteLine("O D4 (Ré4) em sustenido possui a frequência de 311.13 Hz.");
        }
        else
        {
            Console.WriteLine("A frequência permanece em 293.66 Hz.");
        }
        break;
    case 3:
        Console.WriteLine("Frequência: 329.63 Hz.");
        Console.WriteLine("Você gostaria de saber a frequência corresponde em sustenido?");
        Pergunta = Console.ReadLine();
        if (Pergunta == "sim")
        {
            Console.WriteLine("O E4 (Mi4) em sustenido possui a frequência de 349.23 Hz.");
        }
        else
        {
            Console.WriteLine("A frequência permanece em 329.63 Hz.");
        }
        break;
    case 4:
        Console.WriteLine("Frequência: 349.23 Hz.");
        Console.WriteLine("Você gostaria de saber a frequência corresponde em sustenido?");
        Pergunta = Console.ReadLine();
        if (Pergunta == "sim")
        {
            Console.WriteLine("O F4 (Fá4) em sustenido possui a frequência de 369.99 Hz");
        }
        else
        {
            Console.WriteLine("A frequência permanece em 349.23 Hz.");
        }
        break;

    default:
        Console.WriteLine("opção inválida!");
        break;
}

Console.ReadKey();


// resolução do professor abaixo
/*

Console.WriteLine("Escolha uma nota musical:");
Console.WriteLine("1 - Dó (C)");
Console.WriteLine("2 - Ré (D)");
Console.WriteLine("3 - Mi (E)");
Console.WriteLine("4 - Fá (F)");
Console.WriteLine("5 - Sol (G)");
Console.WriteLine("6 - Lá (A)");
Console.WriteLine("7 - Sí (B)");

int nota = Convert.ToInt32(Console.ReadLine());
string resposta;
string resposta1;
switch (nota)
{
    case 1:
        Console.WriteLine("Dó (C) tem frequência de aproximadamente 261.63 Hz");
        Console.WriteLine("Gostaria de saber a nota em sustenido?");
        resposta = Console.ReadLine();
        resposta1 = resposta.ToLower();
            if (resposta1 == "sim")
            {
            Console.WriteLine("Dó Sustenido (C#) tem frequência de aproximadamente 17.32 Hz");
            }
        break;
    case 2:
        Console.WriteLine("Ré (D) tem frequência de aproximadamente 293.66 Hz");
        Console.WriteLine("Gostaria de saber a nota em sustenido?");
        resposta = Console.ReadLine();
        resposta1 = resposta.ToLower();
        if (resposta1 == "sim")
        {
            Console.WriteLine("Ré Sustenido (D#) tem frequência de aproximadamente 19.44 Hz");
        }
        break;
    case 3:
        Console.WriteLine("Mi (E) tem frequência de aproximadamente 329.63 Hz");
        Console.WriteLine("Gostaria de saber a nota em sustenido?");
        resposta = Console.ReadLine();
        resposta1 = resposta.ToLower();
        if (resposta1 == "sim")
        {
            Console.WriteLine("Ré não tem nota sustenida");
        }
        break;
    case 4:
        Console.WriteLine("Fá (F) tem frequência de aproximadamente 349.23 Hz");
        Console.WriteLine("Gostaria de saber a nota em sustenido?");
        resposta = Console.ReadLine();
        resposta1 = resposta.ToLower();
        if (resposta1 == "sim")
        {
            Console.WriteLine("Fá Sustenido (F#) tem frequência de aproximadamente 23.12 Hz");
        }
        break;
    case 5:
        Console.WriteLine("Sol (G) tem frequência de aproximadamente 392.00 Hz");
        Console.WriteLine("Gostaria de saber a nota em sustenido?");
        resposta = Console.ReadLine();
        resposta1 = resposta.ToLower();
        if (resposta1 == "sim")
        {
            Console.WriteLine("Sol Sustenido (G#) tem frequência de aproximadamente 25.95 Hz");
        }
        break;
    case 6:
        Console.WriteLine("Lá (A) tem frequência de aproximadamente 27.50 Hz");
        Console.WriteLine("Gostaria de saber a nota em sustenido?");
        resposta = Console.ReadLine();
        resposta1 = resposta.ToLower();
        if (resposta1 == "sim")
        {
            Console.WriteLine("Lá Sustenido (A#) tem frequência de aproximadamente 29.13 Hz");
        }
        break;
    case 7:
        Console.WriteLine("Si (B) tem frequência de aproximadamente 30.86 Hz");
        Console.WriteLine("Gostaria de saber a nota em sustenido?");
        resposta = Console.ReadLine();
        resposta1 = resposta.ToLower();
        if (resposta1 == "sim")
        {
            Console.WriteLine("A nota Si não tem sustenido");
        }
        break;
    default:
        Console.WriteLine("Nota não reconhecida.");
        break;
}


*/