decimal soma = 1, valor = 1, i;

Console.WriteLine("Digite um valor: ");
valor = Convert.ToInt64(Console.ReadLine());

if(valor > 0)
{
    for (i = 1; i <= valor; i++)
    {
        if (i == 1)
        {
            soma = 1;
        }
        else
        {
            soma += 1 / i;
        }
        if (i == 1)
        {
            Console.Write("S = 1");
        }
        else
        {
            Console.Write(" + 1/" + i);
        }
    }

    Console.WriteLine(" = " + soma);
}
else
{
    Console.WriteLine("Número inválido");
}
