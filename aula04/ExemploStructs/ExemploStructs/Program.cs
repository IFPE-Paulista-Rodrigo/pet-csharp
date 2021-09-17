using ExemploStructs.Entities.Structs;
using System;

namespace ExemploStructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Coords coords = new Coords()
            {
                X = 10,
                Y = 20
            };

            Console.WriteLine(coords.X);
            Console.WriteLine(coords.Y);
            //coords.X = 10;
            Console.WriteLine(coords);
            
            coords = new Coords(2, 3);
            Console.WriteLine(coords);
        }
    }
}
