Int64 valor ,fatorial = 1 , i;

Console.WriteLine("Digite um valor");
valor = Convert.ToInt64(Console.ReadLine());

if(valor < 0)
{
    Console.WriteLine("Número negativo é inválido");
}
else
{
    for (i = 1; i <= valor; i++)
    {
        fatorial *= i;
    }

    Console.WriteLine("O fatorial de " + valor + " é: " + fatorial);
}


