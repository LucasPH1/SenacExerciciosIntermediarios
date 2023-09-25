int lado, i, cont;

Console.WriteLine("Escreva o tamanho do lado do quadrado");
lado = Convert.ToInt32(Console.ReadLine());

Console.Write("\n");
if(lado >= 1 & lado <= 20)
{
    for (cont = 1; cont <= lado; cont++)
    {
        for (i = 1; i <= lado; i++)
        {
            Console.Write("*");
        }
        Console.Write("\n");
    }
}
else
{
    Console.WriteLine("O tamanho do lado deve ser entre 1 e 20");
}


