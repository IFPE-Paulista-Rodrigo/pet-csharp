using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOClasse.Propriedades
{
    class Stock
    {
        decimal currentPrice; // The private "backing" field
        public decimal CurrentPrice // The public property
        {
            get => currentPrice; 
            set => currentPrice = value; 
        }

        
    }
}
