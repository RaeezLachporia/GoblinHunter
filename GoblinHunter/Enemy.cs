using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    abstract class Enemy : Character
    {
        public Random rnd = new Random();
        public String EnemyClassName = " ";
        protected Enemy(int _X, int _Y, TileType _TOT) : base(_X, _Y, _TOT)
        {

        }

        public override string ToString()
        {
            return 
        }
    }
}
