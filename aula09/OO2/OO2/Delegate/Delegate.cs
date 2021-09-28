using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO2.Delegate
{
    public class P1
    {

        public int MethodIWantToCall(string input)
        {
            return input.Length;
        }
    }

    delegate int DelegateWithMatchingSignture(string s);
}
