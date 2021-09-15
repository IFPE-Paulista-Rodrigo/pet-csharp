using System;
using System.Globalization;

namespace EscopoVariavel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Preço da Gasolina
            Console.WriteLine("Informe o valor da gasolina");
            double valorLitro = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe a quantidade de litros");
            double litros = double.Parse(Console.ReadLine());
            double desconto = 0;
            double valorFinal = litros * valorLitro;
            // Se for > 100 litros tem 10% de desconto no valor final
            if (litros >= 100)
            {
                double porcDesconto = 0.1;
                //double desconto = valorFinal * .1;
                desconto = valorFinal * porcDesconto;
                valorFinal -= desconto;
            }
            
            Console.WriteLine("O desconto foi " + desconto.ToString("F2", CultureInfo.InvariantCulture) + " e o " +
                "valor a pagar será: R$ " + valorFinal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
