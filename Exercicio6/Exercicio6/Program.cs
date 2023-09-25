decimal valorCarro, parcela, acrescimo = 0, valorParcela = 0;


Console.WriteLine("Digite o valor do carro: ");
valorCarro = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Quer parcelar em quantas vezes? (1, 6, 12, 18, 24, 30, 36, 42, 48, 54 e 60.");
parcela = Convert.ToInt32(Console.ReadLine());

switch (parcela)
{
    case 1:
        acrescimo = 0.80m;
        break;
    case 6: 
        acrescimo = 1.03m;
        break;
    case 12:
        acrescimo = 1.06m;
        break;
    case 18:
        acrescimo = 1.09m;
        break;
    case 24:
        acrescimo = 1.12m;
        break;
    case 30:
        acrescimo = 1.15m;
        break;
    case 36:
        acrescimo = 1.18m;
        break;
    case 42:
        acrescimo = 1.21m;
        break;
    case 48:
        acrescimo = 1.24m;
        break;
    case 54:
        acrescimo = 1.27m;
        break;
    case 60:
        acrescimo = 1.3m;
        break;
    default:
        Console.WriteLine("Número de parcelas inválido");
        break;

    valorParcela = valorCarro / parcela;

    Console.WriteLine("O preco final da compra é: R$" + (valorCarro * acrescimo));
    Console.WriteLine("Quantidade de parcelas: " + parcela);
    Console.WriteLine("valor de cada parcela: R$" + valorParcela);
}
