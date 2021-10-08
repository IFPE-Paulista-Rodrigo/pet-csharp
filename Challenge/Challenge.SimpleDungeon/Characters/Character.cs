using Challenge.SimpleDungeon.Base;
using Challenge.SimpleDungeon.Game;

namespace Challenge.SimpleDungeon.Characters
{
    public abstract class Character : GridObject
    {
        public int HitPoints { get; protected set; }
        public int Damage { get; protected set; }
        public int RewardPoints { get; protected set; }
        public int X { get; protected set; }
        public int Y { get; protected set; }
        public Character(int hp, int dmg, int reward) : base(false, false)
        {
            HitPoints = hp;
            Damage = dmg;
            RewardPoints = reward;
        }

        public void SetPosition(int x, int y)
        {
            X = x;
            Y = y;
        }

        protected virtual string Move(Grid grid, int oldX, int oldY, int newX, int newY)
        {
            string result = $"You moved to [{X},{Y}]";

            var prevGridObj = grid.GetGridObject(oldX, oldY);
            var nextGridObj = grid.GetGridObject(newX, newY);

            if(nextGridObj.Avatar.Equals("D"))
            {
                result = "\nYou won the game!!!";
            }

            grid.SetGridObject(newX, newY, prevGridObj);
            grid.SetGridObject(oldX, oldY, nextGridObj);

            X = newX;
            Y = newY;

            return result;
        }

        public virtual string DoAction(Grid grid)
        {
            return "";
        }

        public void ApplyDamage(int damage)
        {
            HitPoints -= damage;

            if (HitPoints < 0)
            {
                HitPoints = 0;
            }
        }

        public bool IsAvlive()
        {
            return HitPoints > 0;
        }

        protected string Attack(Character target, Grid grid)
        {
            string msg = "";
            
            target.ApplyDamage(Damage);

            if(!target.IsAvlive() && (target.Avatar.Equals("M") || target.Avatar.Equals("B")))
            {
                grid.SetGridObject(target.X, target.Y, new EmptyGrid());
                RewardPoints += target.RewardPoints;
            }

            if (target.Avatar.Equals("H"))
            {
                var monster = (Avatar.Equals("M")) ? "Monster" : "Boss";
                msg = $"\nYou took {Damage} from {monster}!";
            }
            else
            {
                var monster = (target.Avatar.Equals("M")) ? "Monster" : "Boss";
                msg = $"\nYou caused {Damage} to {monster}!";
            }

            return msg;
        }
    }
}
