using System;

namespace Matriz
{
    internal class MatrixExample
    {
        internal static void PrintExample()
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine("Quantidade de elementos: " + mat.Length);
            Console.WriteLine("Dims = " + mat.Rank);
            Console.WriteLine("Tamanho na dimensão 0 = " + mat.GetLength(0));
            Console.WriteLine("Tamanho na dimensão 1 = " + mat.GetLength(1));

        }

        internal static void PrintExampleJagged()
        {
            int[][] arr = new int[2][];

            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    
    }
}