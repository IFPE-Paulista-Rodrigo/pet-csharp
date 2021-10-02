using System;

namespace ExemplosProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangingConsoleColors();
        }

        public static void ChangingConsoleColors()
        {
            //Documentation
            https://docs.microsoft.com/pt-br/dotnet/api/system.console.foregroundcolor?view=net-5.0

            // Display current Foreground color
            Console.WriteLine("Cor Padrão do Foreground: {0}",
                                     Console.ForegroundColor);

            //store default color
            ConsoleColor defaultColor = Console.ForegroundColor;

            // Set the Foreground color to blue
            Console.ForegroundColor
                = ConsoleColor.Blue;

            // Display current Foreground color
            Console.WriteLine("Mudando a cor do Foreground: {0}",
                                    Console.ForegroundColor);

            //get all colors
            ConsoleColor[] consoleColors = (ConsoleColor[])ConsoleColor
              .GetValues(typeof(ConsoleColor));

            //Choose a random color for each char
            Random rand = new Random();
            int randPos = -1;
            foreach (var character in "Um texto qualquer".ToUpper())
            {
                randPos = rand.Next(0, consoleColors.Length - 1);
                Console.ForegroundColor = consoleColors[randPos];
                Console.Write(character);
            }

            //backing to normal
            Console.ForegroundColor = defaultColor;
            Console.WriteLine("\nVoltando a cor normal");

        }

    }
}
