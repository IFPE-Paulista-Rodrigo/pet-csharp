using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOClasse
{
    class Panda2
    {
        public Panda2 Mate;
        public void Marry(Panda2 partner)
        {
            Mate = partner;
            partner.Mate = this;
        }
    }
}
