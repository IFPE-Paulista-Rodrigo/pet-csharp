using System;

namespace TiposDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de criação de variáveis do tipo de string/char
            Console.WriteLine("\n----- Exibindo Informações dos tipos inteiros -----");
            IntegerExample.Examples();
            IntegerExample.ShowSize();

            //Exemplo de criação de variáveis de números reais
            Console.WriteLine("\n----- Exibindo Informações dos tipos reais -----");
            RealExample.Examples();
            RealExample.ShowSize();

            Console.WriteLine("\n----- Exibindo Informações do tipo string -----");
            StringExample.Examples();
            StringExample.ShowSize();

            Console.WriteLine("\n----- Exibindo Informações do tipo Boolean -----");
            BooleanExample.Examples();
            BooleanExample.ShowSize();
        }
    }
}
