using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparandoInterface
{
    class Pessoa : IComparable
    {
        public string Nome { get; set; }
        public int CompareTo(object other)
        {
            if (other == null) return 1;
            Pessoa otherObj = other as Pessoa;
            if (otherObj != null)
                return this.Nome.CompareTo(otherObj.Nome);
            else
                throw new ArgumentException("Object is not a Pessoa");
        }
    }
}
