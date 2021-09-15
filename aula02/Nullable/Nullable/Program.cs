using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numNaoNull = 3;

            int? numNull = null;

            int m = numNull ?? 10;

            Console.WriteLine(m);

        }
    }
}
