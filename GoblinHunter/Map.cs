using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    class Map : Enemy
    {
        
        //declaring all the variables for the class
        private Tile [,] mapcontainer;
        public Tile [,] MAPCONTAINER
        {
            get {return mapcontainer;}
            set { mapcontainer = value;}
        }
        private Hero playercharacter;
        public Hero PLAYERCHARACTER
        {
            get { return playercharacter;}
            set { playercharacter = value;}
        }
        private List<Enemy> enemies;
        public List<Enemy> ENEMIES
        {
            get { return enemies;}
            set { enemies = value;}
        }
        private int mapwidth;
        public int MAPWIDTH
        {
            get { return mapwidth;}
            set { mapwidth = value;}
        }
        private int mapheight;
        public int MAPHEIGHT
        {
            get { return mapheight;}
            set { mapheight = value;}
        }
        
       
        //created a random number generator to determine the random values for the grid 
        protected Random RANDOM_NUMBER_GENERATOR = new Random();

        //declared a constructor for the class ad declaring newer variables for the minimum and maximum variables for the height and width
        public Map(int _EnemyX,int _EnemyY,int _eMAXHP,int _eDamage,String _ESYMBOL,TileType _TOT,int _MINWIDTH, int _MAXWIDTH, int _MINHEIGHT, int _MAXHEIGHT, int _NUMBEROFENEMIES) : base(_EnemyX, _EnemyY,_eMAXHP,_eDamage,_ESYMBOL, _TOT)
        {
           MAPWIDTH = RANDOM_NUMBER_GENERATOR.Next(_MINWIDTH,_MAXWIDTH);
           MAPHEIGHT = RANDOM_NUMBER_GENERATOR.Next(_MINHEIGHT,_MAXHEIGHT);
           
           MAPCONTAINER = new Tile[MAPWIDTH,MAPHEIGHT];
           
           ENEMIES = new List<Enemy>();
           generateMap();

           updateVision(_MINHEIGHT,_MAXHEIGHT,_MINWIDTH,_MAXWIDTH,_NUMBEROFENEMIES);
           
        }

        public Map(int _EnemyX, int _EnemyY, int _eMAXHP, int _eDamage, string _ESYMBOL, TileType _TOT) : base(_EnemyX, _EnemyY, _eMAXHP, _eDamage, _ESYMBOL, _TOT)
        {
        }

        public void UpdateVision()
        {
            foreach(Enemy E in enemies)
            {
                
                if (E.X >0)
	            {
                 E.Add(MAPCONTAINER[E.X-1,E.Y]);   
	            }

            }
        }
        //method generates the map with the "x" symbol used as the barrier blocks that the player cannot pass through 
        void generateMap()
        {
            for (int y = 0; y < MAPWIDTH; y++)
            {
                for (int x = 0; x <MAPHEIGHT; x++)
                {
                    if (x == 0 || x == MAPWIDTH - 1 || y == 0 || y == MAPHEIGHT)//BORDER
                    {
                        //create the barrier blocks that the player cant move past
                        Create(TileType.Barrier,x,y);

                    }
                    else
                    {
                        //creates empty tiles that the player can move around in
                        Create(TileType.Empty,x,y);

                    }
                }
            }
            Create(TileType.Hero);
            for (int e = 0; e < ENEMIES.Count; e++)
			{
                Create(TileType.Enemy);
			}

        }

        public void Create(TileType TOT, int x= 0, int y = 0)
        {
            switch (TOT)
            {
                case TileType.Barrier:
                    Obstacle NewBarrier = new Obstacle(X,Y,TOT,"#");
                    MAPCONTAINER[X,Y] = NewBarrier;
                    break;
                case TileType.Empty:
                    EmptyTile NewEmptyTile = new EmptyTile();
                    MAPCONTAINER[X,Y] = NewEmptyTile;
                    break;
                case TileType.Hero:
                    int heroX = RANDOM_NUMBER_GENERATOR.Next(0,MAPWIDTH);
                    int heroY = RANDOM_NUMBER_GENERATOR.Next(0,MAPHEIGHT);

                    while(MAPCONTAINER[heroX,heroY].TOT != TileType.Empty)
                    {
                        heroX = RANDOM_NUMBER_GENERATOR.Next(0,MAPWIDTH);
                        heroY = RANDOM_NUMBER_GENERATOR.Next(0,MAPHEIGHT);
                    }

                    Hero newHero = new Hero(heroX, heroY, TOT, 100, 100, 2, 'H');
                    PLAYERCHARACTER  = newHero;
                    MAPCONTAINER[heroX,heroY] = newHero;
                    break;
                case TileType.Enemy:
                    int enemyX = RANDOM_NUMBER_GENERATOR.Next(0, MAPWIDTH);
                    int enemyY = RANDOM_NUMBER_GENERATOR.Next(0,MAPHEIGHT);

                    while(MAPCONTAINER[enemyX,enemyY].TOT != TileType.Empty)
                    {
                        enemyX = RANDOM_NUMBER_GENERATOR.Next(0,MAPWIDTH);
                        enemyY = RANDOM_NUMBER_GENERATOR.Next(0, MAPHEIGHT);
                    }

                    Goblin NewEnemy = new Goblin(enemyX, enemyY, TOT,eMAXHP,"G", 10,1);
                    ENEMIES.Add(NewEnemy);
                    MAPCONTAINER[enemyX,enemyY] = NewEnemy;
                    break;
                case TileType.Gold:
                    break;
            }
        }
        public override string ToString()
        {
            String MapString = "";
            for (int y = 0; y < MAPWIDTH; y++)
			{
                for (int x = 0; x < MAPHEIGHT; x++)
			    {
                    MapString += MAPCONTAINER[x,y].Symbol;
			    }
                MapString+= "\n";
			}
            return MapString;
        }

        public void updateVision(Goblin gobVision, int _mapMinHGHT, int _mapMaxHGHT, int _mapMinWDTH, int _mapMaxWDTH, int _enemies)
        {



        }
    }
}
