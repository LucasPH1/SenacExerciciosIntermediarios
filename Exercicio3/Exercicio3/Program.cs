decimal valorHora, quantidadeHoras, salarioBruto, FGTS, IR = 0, sindicato, salarioLiquido, totalDescontos, valorPorcento= 0;

Console.WriteLine("Digite o valor da sua hora ");
valorHora = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quantidade de horas trabalhadas no mês");
quantidadeHoras = Convert.ToDecimal(Console.ReadLine());

salarioBruto = valorHora * quantidadeHoras;
sindicato = salarioBruto * 0.03m;
FGTS = salarioBruto * 0.11m;


if(salarioBruto >= 900 && salarioBruto < 1500)
{
    IR = salarioBruto * 0.05m;
    valorPorcento = 5;
}
else if(salarioBruto >= 1500 && salarioBruto < 2500)
{
    IR = salarioBruto * 0.1m;
    valorPorcento = 10;
}
else if (salarioBruto >= 2500)
{
    IR = salarioBruto * 0.2m;
    valorPorcento = 20;
}

totalDescontos = IR + sindicato;
salarioLiquido = salarioBruto - totalDescontos;

Console.WriteLine("Salário Bruto" + "(" + valorHora + "*" + quantidadeHoras + ")" + ": R$" + salarioBruto);
Console.WriteLine("( – ) IR (" + valorPorcento + "%): R$" + IR);
Console.WriteLine("( – ) Sindicato(3% ): R$" + sindicato);
Console.WriteLine("FGTS ( 11%): R$" + FGTS);
Console.WriteLine("Total de descontos: R$" + totalDescontos);
Console.WriteLine("Salário Liquido: R$" + salarioLiquido);
