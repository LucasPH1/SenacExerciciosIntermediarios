Int32 numero1, numero2, numero3, maiorNumero = 0, menorNumero = 0, numeroMeio;

Console.WriteLine("Digite um número: ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite um número: ");
numero2 = Convert.ToInt32(Console.ReadLine());

maiorNumero = numero1;
menorNumero = numero2;

if (maiorNumero < numero2)
{
    maiorNumero = numero2;
    menorNumero = numero1;
}

Console.WriteLine("Digite um número: ");
numero3 = Convert.ToInt32(Console.ReadLine());

if (numero3 > maiorNumero)
{
    maiorNumero = numero3;
}
else if (numero3 < menorNumero)
{
    menorNumero = numero3;
}

if (maiorNumero != numero1 & menorNumero != numero1)
{
    numeroMeio = numero1;
}
else if (maiorNumero != numero2 & menorNumero != numero2)
{
    numeroMeio = numero2;
}
else
{
    numeroMeio = numero3;
}
if(numero1 == numero2)
{
    numeroMeio = numero1;
}
if(numero1 == numero3)
{
    numeroMeio = numero1;
}

Console.WriteLine(maiorNumero + " " + numeroMeio + " " + menorNumero);