using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    class Goblin : Enemy
    {
        Goblin [] gobVision = new Goblin[4];
        int gobDirection;


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

        public int directionRoll()
        {
            int 
            return 
        }


        public Goblin(int _X, int _Y, TileType _TOT,int _Health,int _Damage) : base(_X, _Y, _TOT)
        {
            Health = 10;
            health = _Health;
            Damage = 1;
            Damage = _Damage;
        }
        

        public override ReturnMove()
        {
            
        }

        

    }
}
