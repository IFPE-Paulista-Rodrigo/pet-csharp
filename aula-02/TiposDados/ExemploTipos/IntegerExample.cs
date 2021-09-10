using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploTipos
{
    class IntegerExample
    {
        

        public static void Examples()
        {
            /*
             *  Tipos byte, long and int;
             */
            
            uint naturalNumber = 2300;

            // integer means negative or positive whole number
            // including 0
            int integerNumber = -23;

            byte number = 200;

            long longNumber = 2000000L;
        }

        
        public static void ShowSize()
        {
            Console.WriteLine($"byte uses {sizeof(byte)} bytes and can store " +
                $"numbers in the range { byte.MinValue:N0} to { byte.MaxValue:N0}.");

            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in " +
                $"the range { int.MinValue:N0} to { int.MaxValue:N0}.");

            Console.WriteLine($"uint uses {sizeof(uint)} bytes and can store numbers in " +
            $"the range { uint.MinValue:N0} to { uint.MaxValue:N0}.");

            Console.WriteLine($"long uses {sizeof(long)} bytes and can store " +
                $"numbers in the range { long.MinValue:N0} to { long.MaxValue:N0}.");
        }
    }
}
