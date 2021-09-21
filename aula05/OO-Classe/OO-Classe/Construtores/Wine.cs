using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOClasse
{
    public class Wine
    {

        public decimal Price;
        public int Year;
        public Wine(decimal price) { Price = price;  }
        public Wine(decimal price, int year) : this(price) { Year = year;  }
        public Wine(decimal price, DateTime year) : this(price, year.Year) { }
    }
}
