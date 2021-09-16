using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nVetor");
            ArrayExample.PrintExample();
            
            Console.WriteLine("\nMatriz");
            MatrixExample.PrintExample();

            Console.WriteLine("\nMatriz Denteadas");
            MatrixExample.PrintExampleJagged();
        }
    }
}
