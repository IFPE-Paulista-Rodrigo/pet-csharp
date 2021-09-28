using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOClasse.Heranca
{
    class ClassA
    {
        public int Counter = 1;
    }

    class ClassB : ClassA
    {
        public new int Counter = 2;
    }
}
