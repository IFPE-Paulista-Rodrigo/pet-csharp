using System;
using System.Collections.Generic;
using System.Text;

namespace Matriz
{
    class ArrayExample
    {
        public static void PrintExample()
        {
            string[] names = new string[4];

            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";

            for (int i = 0; i < names.Length; i += 1)
            {
                Console.WriteLine(names[i]);
            }

        }
    }
}
