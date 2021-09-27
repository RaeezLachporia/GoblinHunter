using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    class Map : Enemy
    {
        //declaring all the variables for the class
        Boolean keyPress = false;
        Tile[,] tileArr;
        //tile 14, 7. 14,6. 14,5. 14,4. 14,3. 14,2. 14,1. 14,0 = impassable
        //0,7. 1.7. 2,7. and so on, also impassable. also the opposite side.
        public Enemy[] enemies = new Enemy[5];
        Goblin[] gobVision = new Goblin[4];
        Obstacle barrier;
        int mapMinHGHT = 8;
        int mapMaxHGHT = 14;
        int mapMaxWDTH = 8;
        int mapMinWDTH = 4;
        int X;
        int Y;
        
        // Hero playerCharacter = new Hero
        //Enemy[1] = 2;
        //list declared for the map width and height 
        public List<List<Tile>> tiles = new List<List<Tile>>();
        public int mapSizeWDTH;
        public int mapSizeHGHT;
        //created a random number generator to determine the random values for the grid 
        Random rMAP = new Random();


        //declared a constructor for the class ad declaring newer variables for the minimum and maximum variables for the height and width
        public Map(int _X, int _Y, TileType _TOT, int _Damage, int _MAXHP, int _mapMinHGHT, int _mapMaxHGHT, int _mapMinWDTH, int _mapMaxWDTH) : base(_X, _Y, _TOT, _Damage, _MAXHP)
        {
            _X = X;
            _Y = Y;
            _TOT = TOT;
            
            mapMinHGHT = _mapMinHGHT;
            mapMaxHGHT = _mapMaxHGHT;
            mapMinWDTH = _mapMinWDTH;
            mapMaxWDTH = _mapMaxWDTH;

            tileArr = new Tile[rMAP.Next(mapMinWDTH, mapMaxWDTH), rMAP.Next(mapMinHGHT, mapMaxHGHT)];

            tileArr[0, 0] = new Obstacle();
        }
        //method generates the map with the "x" symbol used as the barrier blocks that the player cannot pass through 
        void generateMap()
        {
            for (int y = 0; y < tileArr.GetLength(1); y++)
            {
                for (int x = 0; x <tileArr.GetLength(0); x++)
                {
                    if (x == 0 || x == tileArr.GetLength(0)- 1 || y == 0 || y == tileArr.GetLength(1))
                    {
                        //barriers
                        
                    }
                    else
                    {
                        //create empty here

                    }
                }
            }
        }

        public Goblin Character { get; private set; }

        //declaring the hero objects to be used in the class
        public void heroObject()
        {
            int heroLocX;
            int heroLocY;

        }
        //a method that updates the enemies vision when the player moves 
        public void updateVision(Goblin gobVision, int _mapMinHGHT, int _mapMaxHGHT, int _mapMinWDTH, int _mapMaxWDTH, int _enemies)
        {
         //
        }
    }
}
