using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO2.Delegate
{
    class MethodClass
    {
        public void Method1(string message)
        {
            Console.WriteLine("Calling Method1 = " + message);
        }
        public void Method2(string message)
        {
            Console.WriteLine("Calling Method2 = " + message);
        }
    }
}
