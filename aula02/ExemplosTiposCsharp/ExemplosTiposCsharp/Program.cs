using System;
using System.Globalization;

namespace ExemplosTiposCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorDecimalDouble = 10.35783;
            float valorDecimalFloat = 2.43f;
            int num = 32;
            long numLong = 32L;
            string nome = "Maria";
            char caracter = 'F';

            int num2 = default(int);

            Console.WriteLine(num2);
            Console.WriteLine("O valor é " + valorDecimalDouble.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor é " + valorDecimalDouble.ToString("F1"));

            Console.WriteLine(" " + valorDecimalDouble + " " + num + "  " + nome);

            Console.WriteLine("InT max "  + int.MaxValue);
            Console.WriteLine("InT min " + int.MinValue);
        }
    }
}
