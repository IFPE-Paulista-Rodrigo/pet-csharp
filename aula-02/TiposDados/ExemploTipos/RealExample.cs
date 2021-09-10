using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploTipos
{
    class RealExample
    {
        public static void Examples()
        {
            float? number = null;
            float defaulFloatValue = default(float);

            // float means single-precision floating point
            // F suffix makes it a float literal
            float realNumber = 2.3F;

            // double means double-precision floating point
            double anotherRealNumber = 2.3; // double literal

            // decimal is more accurate
            // M suffix makes it a decimal literal
            decimal decimalNumber = 2.3M; // decimal literal
        }

        public static void DoublePrecision()
        {
            Console.WriteLine("Using doubles:");
            double num1 = 0.1;
            double num2 = 0.2;
            if (num1 + num2 == 0.3)
            {
                Console.WriteLine($"{num1} + {num2} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{num1} + {num2} does NOT equal 0.3");
            }
        }

        public static void DecimalPrecision()
        {
            Console.WriteLine("Using doubles:");
            decimal num1 = 0.1M;
            decimal num2 = 0.2M;
            if (num1 + num2 == 0.3M)
            {
                Console.WriteLine($"{num1} + {num2} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{num1} + {num2} does NOT equal 0.3");
            }
        }
        public static void ShowSize()
        {
            Console.WriteLine($"float uses {sizeof(float)} bytes and can store numbers in " +
                $"the range { float.MinValue:N0} to { float.MaxValue:N0}.");

            Console.WriteLine($"double uses {sizeof(double)} bytes and can store " +
                $"numbers in the range { double.MinValue:N0} to { double.MaxValue:N0}.");

            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store " +
                $"numbers in the range { decimal.MinValue:N0} to { decimal.MaxValue:N0}.");
        }
    }
}
