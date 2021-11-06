using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    class Goblin : Enemy
    {
        public Goblin[] gobVision;
        int gobDirection;
        public Random rnd = new Random();

        private int health;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        private int damage;
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public Goblin(int _EnemyX, int _EnemyY, TileType _TOT, int _eMAXHP, String _ESYMBOL = "G", int _HP = 10, int _eDamage = 1) : base(_EnemyX, _EnemyY,_eMAXHP,_eDamage,_ESYMBOL, _TOT)
        {

        }
        public  Movement GetMovement ()
        {
            int RandomTileIndex = rnd.Next(0, gobVision.Length);
            while (gobVision[RandomTileIndex].TOT.Equals(typeof(EmptyTile)))
            {
                RandomTileIndex = rnd.Next(0, gobVision.Length);
            }
            if (gobVision[RandomTileIndex].X > X)
            {
                return Movement.Right;
            }
            else if (gobVision[RandomTileIndex].X < X)
            {
                return Movement.Left;
            }
            else if (gobVision[RandomTileIndex].Y > Y)
            {
                return Movement.Up;
            }
            else if (gobVision[RandomTileIndex].Y < Y)
            {
                return Movement.Down;
            }
            else
            {
                return Movement.noMovement;
            }
        }

    }


       




    
}
