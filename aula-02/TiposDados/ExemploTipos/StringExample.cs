using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploTipos
{
    class StringExample
    {
        public static void Examples()
        {
            /*
             * Tipos char e string
             */
            char letter = 'A'; // assigning literal characters
            char digit = '1';
            char symbol = '$';
            Console.WriteLine($"{letter} - {digit} - {symbol}");

            string firstName = "Bob"; // assigning literal strings
            string lastName = "Smith";
            string phoneNumber = "(215) 555-4256";
            string name = firstName + " " + lastName;
            Console.WriteLine($"{firstName} - {lastName} - {phoneNumber}");
            Console.WriteLine($"{name}");

            string fullNameWithTabSeparator = "Bob\tSmith";
            Console.WriteLine($"{fullNameWithTabSeparator}");

            //string filePath = "C:\televisions\sony\bravia.txt";
            string filePath = @"C:\televisions\sony\bravia.txt";
            Console.WriteLine($"{filePath}");

            string language = null; // Reference type
            Console.WriteLine($"{language}");
        }

        public static void ShowSize()
        {

            Console.WriteLine($"char uses {sizeof(char)} bytes and can store numbers in " +
                $"the range { char.MinValue:N0} to { char.MaxValue:N0}.");

            /*
            Console.WriteLine($"string uses {sizeof(string)} bytes and can store " +
                $"numbers in the range { string.MinValue:N0} to { string.MaxValue:N0}.");
            */

        }
    }
}
