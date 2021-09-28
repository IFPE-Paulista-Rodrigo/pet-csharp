using System;
using OOConstante;
using OOClasse.Constructor;
using OOClasse.Finalizadores;
using OOClasse.Metodos;
using OOClasse.Indexadores;
using OOClasse.Heranca;
using System.Threading;
namespace OOClasse
{
    class Program
    {

        public static void Display(Asset asset)
        {
            Console.WriteLine(asset.Name);
        }

        static void Main(string[] args)
        {
            /*   Octopus octo = new Octopus();

               octo.Age = 30;
               octo.Name = "Sr. K";
               Console.WriteLine(octo.Age);
               Console.WriteLine(octo.Name);

               Pessoa rodrigo = new Pessoa();
               Pessoa rodrigo2 = rodrigo;*/

            /*  Wine vinho1 = new Wine(20.2m);
              Console.WriteLine(vinho1.Price);

              Wine vinho2 = new Wine();*/

            /*  Bunny bunny = new Bunny("Rui")
              {
                  LikesCarrots = true,
                  LikesHumans = false,                
              };*/

            /*var rect = new Rectangle(3, 4);

            (float width, float height) = rect;

            Console.WriteLine(width);
            Console.WriteLine(height);*/
            /*
                        Metodos.ExampleMethod ex = new ExampleMethod();
                        Console.WriteLine(ex.Foo(10));
                        ex.FooBar(100);*/

            /*  Panda2 p1 = new Panda2();
              Panda2 p2 = new Panda2();

              p1.Marry(p2);

              Console.WriteLine("Finalizado");*/

            /*  Stock2 stock = new Stock2();
              Console.WriteLine(stock.CurrentPrice);

              stock.CurrentPrice = 20;
              Console.WriteLine(stock.CurrentPrice);*/

            /*    Sentence sentenca = new Sentence();
                Console.WriteLine(sentenca[3]);
                sentenca[3] = "Kangaroo";
                Console.WriteLine(sentenca[3]);*/

            /*TestStatic t1 = new TestStatic();
            TestStatic t2 = new TestStatic();
            TestStatic t3 = new TestStatic();
*/
            /*ClassFinalizador exFinalizador = null;
            for (int i = 0; i < 10; i++)
            {
                exFinalizador = new ClassFinalizador();
                Thread.Sleep(500);
                GC.Collect();
            }*/

            /*House mansion = new House { Name = "McMansion", Mortgage = 250000 };
            Asset a = mansion;
            Console.WriteLine(a.Liability);
            Console.WriteLine(mansion.Liability);
*/

            Overrider over = new Overrider();
            BaseClass b1 = over;
            over.Foo();
            b1.Foo();

            Hider h = new Hider();
            BaseClass b2 = h;
            h.Foo();
            b2.Foo();
        }
    }
}
