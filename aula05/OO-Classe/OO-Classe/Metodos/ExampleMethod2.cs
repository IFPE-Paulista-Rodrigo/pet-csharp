using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOClasse.Metodos
{
    class ExampleMethod2
    {
        /* Overloading methods */

        internal void Foo(int x) { }
        internal void Foo(double x) { }
        internal void Foo(int x, float y) { }
        internal void Foo(float x, int y) { }
    }
}
