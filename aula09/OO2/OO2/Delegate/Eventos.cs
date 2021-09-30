using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO2.Delegate
{
    class Person
    {
        public EventHandler Shout;
        public string Name { set; get;}
        public int AngerLevel { get; private set;  } = 0;
        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                if (Shout != null)
                {
                    Shout(this, EventArgs.Empty);
                }
            }
        }

        
    }
}
