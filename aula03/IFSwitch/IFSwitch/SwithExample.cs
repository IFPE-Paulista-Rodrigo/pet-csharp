using System;
using System.Collections.Generic;
using System.Text;

namespace IFSwitch
{
    internal class SwithExample
    {
        internal static void Example1()
        {
            var number = new Random().Next(1, 7);
            Console.WriteLine($"My random number is {number}");
            switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    break; // jumps to end of switch statement
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Three or four");
                    break;
                case 5:
                    // go to sleep for half a second
                    Console.WriteLine("Sleeping for 0.5s");
                    System.Threading.Thread.Sleep(500);
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }

        internal static void Example2()
        {
            DisplayMeasurement(-4);  // Output: Measured value is -4; too low.
            DisplayMeasurement(5);  // Output: Measured value is 5.
            DisplayMeasurement(30);  // Output: Measured value is 30; too high.
            DisplayMeasurement(double.NaN);  // Output: Failed measurement.

            void DisplayMeasurement(double measurement)
            {
                switch (measurement)
                {
                    case < 0.0:
                        Console.WriteLine($"Measured value is {measurement}; too low.");
                        break;

                    case > 15.0:
                        Console.WriteLine($"Measured value is {measurement}; too high.");
                        break;

                    case double.NaN:
                        Console.WriteLine("Failed measurement.");
                        break;

                    default:
                        Console.WriteLine($"Measured value is {measurement}.");
                        break;
                }
            }
        }
        internal static void SwitchExpressionExample()
        {
            var number = new Random().Next(1, 7);
            Console.WriteLine($"My random number is {number}");
            string message = number switch
            {
                1 => "One",
                2 => "Two",
                3 or 4 => "Three or Four",
                _ => "Default",
            };

            Console.WriteLine(message);
        }
    }
}
