using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOClasse.Heranca
{
    public abstract class Asset
    {
        public string Name;

        public virtual decimal Liability => 0;

        public abstract decimal netValue();
    }

    public class House : Asset
    {
        public decimal Mortgage;
        public override decimal Liability => Mortgage;

        public override decimal netValue()
        {
            return Mortgage;
        }

    }

    public class Stock : Asset
    {
        public long SharesOwned;
        public decimal CurrentPrice;

        public override decimal netValue()
        {
            return SharesOwned * CurrentPrice;
        }
    }


}
