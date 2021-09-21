using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOClasse
{
    class ExampleMethod
    {
        /* Expression-bodied methods */ 

        //private int Foo(int x) { return x * 2; }
        private int Foo (int x) => x * 2;
        
        void FooBar(int x) => Console.WriteLine(x);
    }
}
