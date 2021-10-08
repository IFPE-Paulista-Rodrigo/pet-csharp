using System;

namespace Challenge.SimpleDungeon.Pickables
{
    public class Weapon : Pickable
    {
        public Weapon() : base(0, 2)
        {
            Avatar = "W";
            Color = ConsoleColor.Yellow;
        }
    }
}
