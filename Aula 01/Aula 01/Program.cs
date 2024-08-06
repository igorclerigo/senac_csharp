// See https://aka.ms/new-console-template for more information
Console.WriteLine("Olá, mundo!");



// Tipos de dados
int numero = 42;
int numero2 = 22;
string mensagem = "Este é um exemplo de estrutura básica.";
double PontoFlutuante = 42.5;
float PontoFlutuante1 = 42.5f;


// Exemplo de concatenação na linha 10
Console.WriteLine("O número é: " + numero);
Console.WriteLine(mensagem);
Console.WriteLine(PontoFlutuante);
Console.Write(PontoFlutuante);

// Não da pra somar variáveis dentro do WriteLine, pois, somente ocorre a concatenação
Console.WriteLine(numero + numero2);

// Não da pra somar variáveis de tipos diferentes
// int soma = PontoFlutuante + PontoFlutuante1;

// O jeito correto de fazer é:
int soma = numero + numero2;
Console.WriteLine("A soma de" + numero + "+" + numero2 + "é: " + soma);

// Mantem a janela do console aberta até que uma tecla seja pressionada
Console.ReadKey();
