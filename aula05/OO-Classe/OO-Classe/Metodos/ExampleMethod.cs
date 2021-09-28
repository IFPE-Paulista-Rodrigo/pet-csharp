using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOClasse.Metodos
{
    public class ExampleMethod
    {
        /* Expression-bodied methods */ 

        
        /*public int Foo(int x) 
        { 
            return x * 2; 
        }*/
        
        public int Foo (int x) => x * 2;
        
        public void FooBar(int x) => Console.WriteLine(x);
    }
}
