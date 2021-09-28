using System;
using OO2.Interfaces;

namespace OO2
{
    class Program
    {
        static void Main(string[] args)
        {

            //IEnumerator e = new Coutdown();
            IEnumerator e = new CountUp();

            //((CountUp)e).printCurrent();

            /*while (e.MoveNext())
                Console.WriteLine(e.Current);*/

            Logger logger = new Logger();
            logger.Log("Teste");

        }
    }
}
