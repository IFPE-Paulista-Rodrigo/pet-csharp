using System;
using OO2.Interfaces;
using OO2.Delegate;
using OO2.Generics;

namespace OO2
{
    class Program
    {
        static void Main(string[] args)
        {

            //IEnumerator e = new Coutdown();
            //IEnumerator e = new CountUp();

            //((CountUp)e).printCurrent();

            /*while (e.MoveNext())
                Console.WriteLine(e.Current);*/

            /* ILoggerPrefix logger = new Logger();
             logger.Log("Teste");
             */

            /* var stack = new Stack<int>();
             stack.Push(5);
             stack.Push(10);

             int x = stack.Pop();
             int y = stack.Pop();

             Console.WriteLine("x = " + x + " y = " + y);*/

            /* P1 p1 = new P1();

             int retorno = p1.MethodIWantToCall("Olá");
             Console.WriteLine(retorno);

             var d = new DelegateWithMatchingSignture(p1.MethodIWantToCall);
             int retornoDelegate = d("Olá");
             Console.WriteLine(retornoDelegate);
 */
            /*
                        Del handler = TestDelegate.DelegateMethod;
                        handler("Hello World");

                        TestDelegate.MethodWithCallback(1, 3, handler);

            */
            /* var obj = new MethodClass();
             Del d1 = obj.Method1;
             Del d2 = obj.Method2;
             Del d3 = TestDelegate.DelegateMethod;


             Del allMethodsDelegate = d1 + d2;
             allMethodsDelegate += d3;
             allMethodsDelegate("Exemplo de chamada");

             allMethodsDelegate -= d1;
             allMethodsDelegate("Exemplo de chamada");

             int count = allMethodsDelegate.GetInvocationList().GetLength(0);
             Console.WriteLine(count);*/


            Person harry = new Person() { Name = "Harry" };
            harry.Shout = HarryShout;
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();

        }

        internal static void HarryShout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            Console.WriteLine($"{p.Name} is the angry: {p.AngerLevel}");
        }
    }
}
