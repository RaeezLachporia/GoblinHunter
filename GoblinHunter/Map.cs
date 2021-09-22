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
        private Tile Create();
        
        public void heroObject();
           
        

        Random r = new Random();

        Random rnd = new Random();




        public Goblin Character { get; private set; }

        public Map(int _X, int _Y, TileType _TOT, int _mapMinHGHT, int _mapMaxHGHT, int _mapMinWDTH, int _mapMaxWDTH, int _enemies) : base(_X, _Y, _TOT)
        {
            //the method here requires a random object that randomises the height and width of the map. we werent given one yet so im just praying what i did is fine.
            mapMinHGHT = _mapMinHGHT;
            mapMaxHGHT = _mapMaxHGHT;
            mapMinWDTH = _mapMinWDTH;
            mapMaxWDTH = _mapMaxWDTH;
        }

        public void heroObject()
        {
            int heroLocX;
            int heroLocY;

        }

        {
            rnd.Next(gobVision);


            
            }
            if gobVision.Contains int _X && int _Y
            {


        }
        

        
    }*/
    }
}
