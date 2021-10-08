using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.SimpleDungeon.Pickables
{
    public class Potion : Pickable
    {
        public Potion() : base(6, 0)
        {
            Avatar = "P";
            Color = ConsoleColor.Green;
        }
    }
}
