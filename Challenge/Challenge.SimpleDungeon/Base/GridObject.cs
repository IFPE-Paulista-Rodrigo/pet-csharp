using System;

namespace Challenge.SimpleDungeon.Base
{
    public abstract class GridObject
    {
        public bool CanStepOver { get; protected set; }
        public bool IsPickable { get; protected set; }
        public string Avatar { get; protected set; }
        public ConsoleColor Color { get; protected set; }

        public GridObject(bool canStepOver, bool pickable)
        {
            CanStepOver = canStepOver;
            IsPickable = pickable;
            Avatar = "O";
            Color = ConsoleColor.White;
        }
    }
}
