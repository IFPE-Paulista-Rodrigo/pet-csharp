using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO2.Interfaces
{
    class Countdown : IEnumerator
    {
        int count = 11;

        public bool MoveNext() => count-- > 0;
        public object Current => count;
        public void Reset() { throw new NotSupportedException(); }

    }

    class CountUp : IEnumerator
    {
        int count = 0;

        public bool MoveNext() => count++ < 10;

        public object Current => count;

        public void Reset() { throw new NotSupportedException(); }

        public void printCurrent()
        {
            Console.WriteLine(Current);
        }
    }
}
