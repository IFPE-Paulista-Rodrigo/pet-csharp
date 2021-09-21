using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOClasse
{
    class Stock
    {
        decimal currentPrice; // The private "backing" field
        public decimal CurrentPrice // The public property
        {
            get { return currentPrice; }
            set { currentPrice = value; }
        }
    }
}
