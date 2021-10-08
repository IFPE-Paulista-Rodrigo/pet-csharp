using System;
using Challenge.SimpleDungeon.Characters;

namespace Challenge.SimpleDungeon.Game
{
    public class Dungeon
    {
        private int mNumMonsters = 5;
        private int mNumBosses = 1;
        private int mNumPotions = 8;
        private int mNumWeapons = 1;
        private int mGridSizeX = 20;
        private int mGridSizeY = 20;

        private Grid mGrid;
        private Hero mHero;

        private string mLastActionResult;

        public Dungeon()
        {
            mHero = new Hero();
            mGrid = new Grid(mGridSizeX, mGridSizeY);
            mGrid.Initialize(mHero, mNumMonsters, mNumBosses, mNumPotions, mNumWeapons);
        }

        public void Start()
        {
            ConsoleKeyInfo keyInfo;
            bool gameHasEnded = false;

            do
            {
                Draw();
                keyInfo = Console.ReadKey(true);
                mLastActionResult = ProccessKey(keyInfo);

                if(mLastActionResult.Contains("won the game"))
                {
                    gameHasEnded = true;
                }
                else
                {
                    mLastActionResult += updateNPCActions();
                }

            } while (keyInfo.Key != ConsoleKey.Escape && !gameHasEnded);

            if(gameHasEnded)
            {
                Console.Clear();
                DrawHeader();
                mGrid.Draw();
                DrawResult(mLastActionResult);
            }

            Console.WriteLine("\n Press any key to close...");
            Console.ReadKey(true);
        }

        private string updateNPCActions()
        {
            return mGrid.UpdateNPCActions();
        }

        private string ProccessKey(ConsoleKeyInfo keyInfo)
        {
            string actionResult = "";

            switch (keyInfo.Key)
            {
                case ConsoleKey.A:
                    actionResult = mHero.MoveLeft(mGrid);
                    break;
                case ConsoleKey.D:
                    actionResult = mHero.MoveRight(mGrid);
                    break;
                case ConsoleKey.W:
                    actionResult = mHero.MoveUp(mGrid);
                    break;
                case ConsoleKey.S:
                    actionResult = mHero.MoveDown(mGrid);
                    break;
                case ConsoleKey.Spacebar:
                    actionResult = mHero.TryAttack(mGrid);
                    break;
                default:
                    actionResult = "Invalid action option.";
                    break;
            }

            return actionResult;
        }

        private void Draw()
        {
            Console.Clear();
            DrawHeader();
            mGrid.Draw();
            DrawOptions();
            DrawResult(mLastActionResult);
        }

        private void DrawHeader()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"Hero HP: {mHero.HitPoints} Hero Damage: {mHero.Damage} Hero Score: {mHero.RewardPoints + mHero.HitPoints}");
            Console.WriteLine("=========================================\n");
        }

        private void DrawOptions()
        {
            Console.WriteLine("\n=========================================");
            Console.WriteLine("  [A] to move left.   [D] to move right. ");
            Console.WriteLine("  [W] to move up.     [S] to move down.  ");
            Console.WriteLine("  [SPACE] to attack.  [ESC] to exit.     ");
            Console.WriteLine("=========================================\n");
        }

        private void DrawResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
