namespace Challenge.SimpleDungeon.Characters
{
    public class Boss : NPC
    {
        public Boss() : base(15, 3, 15)
        {
            Avatar = "B";
            Color = System.ConsoleColor.DarkRed;
        }

        public Boss(int x, int y) : base(15, 3, 15)
        {
            X = x;
            Y = y;
            Avatar = "B";
            Color = System.ConsoleColor.DarkRed;
        }
    }
}
