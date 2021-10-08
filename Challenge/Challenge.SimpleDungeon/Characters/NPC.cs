using System;
using Challenge.SimpleDungeon.Game;
using System.Collections.Generic;

namespace Challenge.SimpleDungeon.Characters
{
    public abstract class NPC : Character
    {
        public NPC(int hp, int dmg, int reward) : base(hp, dmg, reward)
        {

        }

        public override string DoAction(Grid grid)
        {
            var directions = new List<(int, int)>();
            if (grid.IsValidPosition(X + 1, Y))
            {
                var gridObj = grid.GetGridObject(X + 1, Y);
                if (gridObj.Avatar.Equals("H"))
                {
                    return Attack(gridObj as Character, grid);
                }
                else if (gridObj.Avatar.Equals("O"))
                {
                    directions.Add((X + 1, Y));
                }
            }

            if (grid.IsValidPosition(X - 1, Y))
            {
                var gridObj = grid.GetGridObject(X - 1, Y);
                if (gridObj.Avatar.Equals("H"))
                {
                    return Attack(gridObj as Character, grid);
                }
                else if (gridObj.Avatar.Equals("O"))
                {
                    directions.Add((X - 1, Y));
                }
            }

            if (grid.IsValidPosition(X, Y + 1))
            {
                var gridObj = grid.GetGridObject(X, Y + 1);
                if (gridObj.Avatar.Equals("H"))
                {
                    return Attack(gridObj as Character, grid);
                }
                else if (gridObj.Avatar.Equals("O"))
                {
                    directions.Add((X, Y + 1));
                }
            }

            if (grid.IsValidPosition(X, Y - 1))
            {
                var gridObj = grid.GetGridObject(X, Y - 1);
                if (gridObj.Avatar.Equals("H"))
                {
                    return Attack(gridObj as Character, grid);
                }
                else if (gridObj.Avatar.Equals("O"))
                {
                    directions.Add((X, Y - 1));
                }
            }

            if (directions.Count > 0)
            {
                var rand = new Random();
                var index = rand.Next(directions.Count);

                Move(grid, X, Y, directions[index].Item1, directions[index].Item2);
            }

            return "";
        }
    }
}
