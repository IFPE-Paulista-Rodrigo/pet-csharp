using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO2.Interfaces
{
    public interface IEnumerator
    {
        /* Os membros são implicitamente públicos */
        bool MoveNext();
        object Current { get;  }
        void Reset();
    }
}
