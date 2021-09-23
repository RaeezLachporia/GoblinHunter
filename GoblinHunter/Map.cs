using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    class Map : Enemy
    {
        Boolean keyPress = false;
        Tile[,] tileArr = new Tile[14, 8];
        //tile 14, 7. 14,6. 14,5. 14,4. 14,3. 14,2. 14,1. 14,0 = impassable
        //0,7. 1.7. 2,7. and so on, also impassable. also the opposite side.
        public Enemy[] enemies = new Enemy[5];
        Goblin[] gobVision = new Goblin[4];
        int mapMinHGHT = 8;
        int mapMaxWDTH = 8;
        int mapMaxHGHT = 14;
        int mapMinWDTH = 4;
        
        //Enemy[1] = 2;
        
        public List<List<Tile>> tiles = new List<List<Tile>>();
        public int mapSize;
       
        Random rHGHT = new Random();
        Random rWDTH = new Random();

        public Map(int _X, int _Y, TileType _TOT, int _Damage, int _MAXHP, int _mapMinHGHT,int _mapMaxHGHT,int _mapMinWDTH,int _mapMaxWDTH) : base(_X, _Y, _TOT, _Damage, _MAXHP)
        {
            //the method here requires a random object that randomises the height and width of the map. we werent given one yet so im just praying what i did is fine.
            mapMinHGHT = _mapMinHGHT;
            mapMaxHGHT = _mapMaxHGHT;
            mapMinWDTH = _mapMinWDTH;
            mapMaxWDTH = _mapMaxWDTH;
        }

        void generateMap(Random rWDTH, Random rHGHT, int mapMinWDTH = 4, int mapMaxWDTH = 8)
        {

            mapSize = rWDTH.Next(mapMinWDTH, mapMaxWDTH);
            Console.WriteLine(rWDTH);

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
    }
}
