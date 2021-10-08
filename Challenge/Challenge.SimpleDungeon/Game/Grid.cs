using System;
using System.Linq;
using System.Collections.Generic;
using Challenge.SimpleDungeon.Base;
using Challenge.SimpleDungeon.Characters;
using Challenge.SimpleDungeon.Pickables;

namespace Challenge.SimpleDungeon.Game
{
    public class Grid
    {
        private Dictionary<(int, int), GridObject> mGrid;
        private int mSizeX;
        private int mSizeY;
        private Random mRand;
        private List<Character> mNPCs;

        public Grid(int sizeX, int sizeY)
        {
            mRand = new Random();
            mSizeX = sizeX;
            mSizeY = sizeY;

            mGrid = new Dictionary<(int, int), GridObject>(sizeX * sizeY);            

            for (int y = 0; y < sizeY; y++)
            {
                for (int x = 0; x < sizeX; x++)
                {
                    mGrid.Add((x, y), new EmptyGrid());
                }
            }
        }

        public void Initialize(Hero hero, int numMonsters, int numBosses, int numPotions, int numWeapons)
        {
            mNPCs = new List<Character>(numMonsters + numBosses);
            hero.SetPosition(0, 0);
            mGrid[(0, 0)] = hero;
            mGrid[(mSizeX - 1, mSizeY - 1)] = new DestinationGrid();

            // Remove the boundaries: first two columns and rows, last two columns and rows.
            var possiblePositions = mGrid.Keys.Where(tuple => (tuple.Item1 >= 2 && tuple.Item1 < mSizeX - 3) && (tuple.Item2 >= 2 && tuple.Item2 < mSizeY - 3)).ToList();

            var rnd = new Random();

            // Spawn monsters
            for (int i = 0; i < numMonsters; i++)
            {
                var index = mRand.Next(possiblePositions.Count);
                var spawnPos = possiblePositions[index];
                var monster = new Monster(spawnPos.Item1, spawnPos.Item2);
                mNPCs.Add(monster);
                mGrid[(spawnPos.Item1, spawnPos.Item2)] = monster;

                possiblePositions.RemoveAt(index);
            }

            // Spawn bosses
            for (int i = 0; i < numBosses; i++)
            {
                var index = mRand.Next(possiblePositions.Count);
                var spawnPos = possiblePositions[index];
                var boss = new Boss(spawnPos.Item1, spawnPos.Item2);
                mNPCs.Add(boss);
                mGrid[(spawnPos.Item1, spawnPos.Item2)] = boss;

                possiblePositions.RemoveAt(index);
            }

            // Spawn potions
            for (int i = 0; i < numPotions; i++)
            {
                var index = mRand.Next(possiblePositions.Count);
                var spawnPos = possiblePositions[index];
                mGrid[(spawnPos.Item1, spawnPos.Item2)] = new Potion();

                possiblePositions.RemoveAt(index);
            }

            // Spawn weapons
            for (int i = 0; i < numWeapons; i++)
            {
                var index = mRand.Next(possiblePositions.Count);
                var spawnPos = possiblePositions[index];
                mGrid[(spawnPos.Item1, spawnPos.Item2)] = new Weapon();

                possiblePositions.RemoveAt(index);
            }
        }

        public void Draw()
        {
            for (int y = 0; y < mSizeY; y++)
            {
                for (int x = 0; x < mSizeX; x++)
                {
                    var gridObject = mGrid[(x, y)];
                    Console.ForegroundColor = gridObject.Color;
                    Console.Write($" {gridObject.Avatar}");
                }

                Console.Write("\r\n");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        public bool IsValidPosition(int x, int y)
        {
            if(x < 0 || y < 0 || x >= mSizeX || y >= mSizeY)
            {
                return false;
            }

            return true;
        }

        public GridObject GetGridObject(int x, int y)
        {
            GridObject gridObject = null;
            mGrid.TryGetValue((x, y), out gridObject);

            return gridObject;
        }

        public void SetGridObject(int x, int y, GridObject gridObject)
        {
            if(mGrid.ContainsKey((x, y)))
            {
                mGrid[(x, y)] = gridObject;
            }
        }

        public string UpdateNPCActions()
        {
            var actions = "";
            foreach (var npc in mNPCs)
            {
                if(npc.IsAvlive())
                {
                    actions += npc.DoAction(this);
                }
            }

            return actions;
        }
    }
}
