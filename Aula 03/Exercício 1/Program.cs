using System.ComponentModel.Design;

Console.WriteLine("### EXERCÍCIO 01 ###");
Console.WriteLine("### OLIMPÍADAS ###");
bool condicao = true;


while (condicao == true)
{
    int pesoouro = 100;
    int pesoprata = 50;

    Console.Write("Atleta, me informe seu nome: ");
    string nome = Console.ReadLine();
    Console.Write("Agora, me informe quantos quilos você levantou: ");
    int peso = Convert.ToInt32(Console.ReadLine());


    Console.Write("Deseja calcular o resultado? (sim/não): ");
    string calculo = Console.ReadLine();

    if (calculo == "sim")
    {
        condicao = false;
        if (peso >= pesoouro)
        {
            Console.WriteLine("Você recebeu a medalha de OURO!");
        }
        else if (peso < pesoouro && peso >= pesoprata)
        {
            Console.WriteLine("Você recebou a medalha de PRATA!");
        }
        else
        {
            Console.WriteLine("Você recebeu a medalha de BRONZE!");
        }
    }
    else
    {
        condicao = true;
    }


}


   
Console.ReadKey();


/*
 double pesoOuro = 0;
double peso;
string nomeOuro = "";
string nome;
bool validador = false;
string resposta;

Console.WriteLine("Digite o nome do atleta");
nome = Console.ReadLine();
Console.WriteLine("Digite o peso levantado");
peso = Convert.ToDouble(Console.ReadLine());

while (validador == false)
{
    if (pesoOuro < peso)
    {
        pesoOuro = peso;
        nomeOuro = nome;
    }
    Console.WriteLine("Gostaria de inserir dados de outro atleta? Sim ou não");
    resposta = Console.ReadLine().ToLower();
    if (resposta == "não" || resposta == "nao")
    {
        validador = true;
    }
    else
    {
        Console.WriteLine("Digite o nome do atleta");
        nome = Console.ReadLine();
        Console.WriteLine("Digite o peso levantado");
        peso = Convert.ToDouble(Console.ReadLine());
    }
}
Console.WriteLine("Atleta que recebeu ouro: " + nomeOuro);
Console.WriteLine("Peso que ele levantou: " + pesoOuro +"kg");

 */