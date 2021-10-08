namespace Challenge.SimpleDungeon.Characters
{
    public class Monster : NPC
    {
        public Monster() : base(5, 1, 5)
        {
            Avatar = "M";
            Color = System.ConsoleColor.Red;
        }

        public Monster(int x, int y) : base(5, 1, 5)
        {
            X = x;
            Y = y;
            Avatar = "M";
            Color = System.ConsoleColor.Red;
        }      
    }
}
