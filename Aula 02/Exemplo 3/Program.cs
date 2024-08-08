int contador = 10;
while (contador > 0)
{
    Console.WriteLine(contador);
    System.Threading.Thread.Sleep(1000);
    contador--;
}
Console.WriteLine("Fogo!");