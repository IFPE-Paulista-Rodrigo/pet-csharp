using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO2.Generics
{

    class SomeClass { }
    interface Interface1 {
        public void PrintConsole();
    }

    class GenericClass<T, U> where T : SomeClass, Interface1 where U : new()
    {

    }
}
