using System.Linq;
using System.Reflection;
using System; 

namespace MetodosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double heightInMeters = 1.88; //camel Case
            Console.WriteLine($"A variável {nameof(heightInMeters)} tem o valor de {heightInMeters}"); //Interpolação
        }
    }
}
