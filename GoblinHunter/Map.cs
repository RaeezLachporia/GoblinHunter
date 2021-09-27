using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    class Map : Enemy
    {
        Boolean keyPress = false;
        Tile[,] tileArr;
        //tile 14, 7. 14,6. 14,5. 14,4. 14,3. 14,2. 14,1. 14,0 = impassable
        //0,7. 1.7. 2,7. and so on, also impassable. also the opposite side.
        public Enemy[] enemies = new Enemy[5];
        Goblin[] gobVision = new Goblin[4];
        int mapMinHGHT = 8;
        int mapMaxHGHT = 14;
        int mapMaxWDTH = 8;
        int mapMinWDTH = 4;
        // Hero playerCharacter = new Hero
        //Enemy[1] = 2;

        public List<List<Tile>> tiles = new List<List<Tile>>();
        public int mapSizeWDTH;
        public int mapSizeHGHT;
        Random rMAP = new Random();


        public Map(int _X, int _Y, TileType _TOT, int _Damage, int _MAXHP, int _mapMinHGHT, int _mapMaxHGHT, int _mapMinWDTH, int _mapMaxWDTH) : base(_X, _Y, _TOT, _Damage, _MAXHP)
        {
            //the method here requires a random object that randomises the height and width of the map. we werent given one yet so im just praying what i did is fine.
            mapMinHGHT = _mapMinHGHT;
            mapMaxHGHT = _mapMaxHGHT;
            mapMinWDTH = _mapMinWDTH;
            mapMaxWDTH = _mapMaxWDTH;

            tileArr = new Tile[rMAP.Next(mapMinWDTH, mapMaxWDTH), rMAP.Next(mapMinHGHT, mapMaxHGHT)];

            tileArr[0, 0] = new Obstacle()
        }

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



        public void heroObject()
        {
            int heroLocX;
            int heroLocY;

        }

        public void updateVision(Goblin gobVision, int _mapMinHGHT, int _mapMaxHGHT, int _mapMinWDTH, int _mapMaxWDTH, int _enemies)
        {



        }


        //if x = [0, 0] 
        //{



        //}
    }
}
