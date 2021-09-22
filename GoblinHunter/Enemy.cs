using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    abstract class Enemy : Character
    {
        public Random rnd = new Random();
        public String EnemyClassName = " ";
        private int damage;

        public int DAMAGE
        {
            get { return damage; }
            set { damage = value; }
        }

        private int maxHp;

        public int MAXHP
        {
            get { return maxHp; }
            set { maxHp = value; }
        }

        protected Enemy(int _X, int _Y, TileType _TOT,int _Damage, int _MAXHP) : base(_X, _Y, _TOT)
        {
            MaxHp = _MAXHP;
            DAMAGE = _Damage;
        }

        public override string ToString()
        {
            return

        }
    }
}
