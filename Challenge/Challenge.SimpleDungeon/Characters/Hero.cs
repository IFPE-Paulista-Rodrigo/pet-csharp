using Challenge.SimpleDungeon.Base;
using Challenge.SimpleDungeon.Game;
using Challenge.SimpleDungeon.Pickables;

namespace Challenge.SimpleDungeon.Characters
{
    public class Hero : Character
    {
        public Hero() : base(20, 1, 0)
        {
            Avatar = "H";
            Color = System.ConsoleColor.Cyan;
        }

        private void pickItem(Pickable item)
        {
            HitPoints += item.HitPointsEffect;
            Damage += item.DamageEffect;
        }

        protected override string Move(Grid grid, int oldX, int oldY, int newX, int newY)
        {
            var nextGridObj = grid.GetGridObject(newX, newY);

            if (nextGridObj.IsPickable)
            {
                pickItem(nextGridObj as Pickable);
                grid.SetGridObject(newX, newY, new EmptyGrid());
            }

            ApplyDamage(1);

            if(IsAvlive())
            {
                return base.Move(grid, oldX, oldY, newX, newY);
            }
            else
            {
                return "You died!";
            }
        }

        public string MoveRight(Grid grid)
        {
            if(!grid.IsValidPosition(X + 1, Y))
            {
                return "Invalid movement action.";
            }

            var nextGridLocation = grid.GetGridObject(X + 1, Y);
            if(nextGridLocation == null || !nextGridLocation.CanStepOver)
            {
                return "Invalid movement action.";
            }

            return Move(grid, X, Y, X + 1, Y);
        }

        public string MoveLeft(Grid grid)
        {
            if (!grid.IsValidPosition(X - 1, Y))
            {
                return "Invalid movement action.";
            }

            var nextGridLocation = grid.GetGridObject(X - 1, Y);
            if (nextGridLocation == null || !nextGridLocation.CanStepOver)
            {
                return "Invalid movement action.";
            }

            return Move(grid, X, Y, X - 1, Y);
        }

        public string MoveUp(Grid grid)
        {
            if (!grid.IsValidPosition(X, Y - 1))
            {
                return "Invalid movement action.";
            }

            var nextGridLocation = grid.GetGridObject(X, Y - 1);
            if (nextGridLocation == null || !nextGridLocation.CanStepOver)
            {
                return "Invalid movement action.";
            }

            return Move(grid, X, Y, X, Y - 1);
        }

        public string MoveDown(Grid grid)
        {
            if (!grid.IsValidPosition(X, Y + 1))
            {
                return "Invalid movement action.";
            }

            var nextGridLocation = grid.GetGridObject(X, Y + 1);
            if (nextGridLocation == null || !nextGridLocation.CanStepOver)
            {
                return "Invalid movement action.";
            }

            return Move(grid, X, Y, X, Y + 1);
        }

        public string TryAttack(Grid grid)
        {
            if (grid.IsValidPosition(X + 1, Y))
            {
                var gridObj = grid.GetGridObject(X + 1, Y);
                if (gridObj != null && (gridObj.Avatar.Equals("M") || gridObj.Avatar.Equals("B")))
                {
                    return Attack(gridObj as Character, grid);
                }
            }

            if (grid.IsValidPosition(X - 1, Y))
            {
                var gridObj = grid.GetGridObject(X - 1, Y);
                if (gridObj != null && (gridObj.Avatar.Equals("M") || gridObj.Avatar.Equals("B")))
                {
                    return Attack(gridObj as Character, grid);
                }
            }

            if (grid.IsValidPosition(X, Y + 1))
            {
                var gridObj = grid.GetGridObject(X, Y + 1);
                if (gridObj != null && (gridObj.Avatar.Equals("M") || gridObj.Avatar.Equals("B")))
                {
                    return Attack(gridObj as Character, grid);
                }
            }

            if (grid.IsValidPosition(X, Y - 1))
            {
                var gridObj = grid.GetGridObject(X, Y - 1);
                if (gridObj != null && (gridObj.Avatar.Equals("M") || gridObj.Avatar.Equals("B")))
                {
                    return Attack(gridObj as Character, grid);
                }
            }

            return "There is nothing to attack.";
        }
    }
}
