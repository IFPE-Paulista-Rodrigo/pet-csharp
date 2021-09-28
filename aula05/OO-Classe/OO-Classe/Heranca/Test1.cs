using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOClasse.Heranca.Test1
{

    class A
    {
        public void Test() { Console.WriteLine("A::Test()"); }
    }

    class B : A
    {
        public void Test() { Console.WriteLine("B::Test()"); }
    }

    class C : B
    {
        public void Test() { Console.WriteLine("C::Test()"); }
    }
}
