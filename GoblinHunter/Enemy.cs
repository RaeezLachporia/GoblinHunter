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

        }

        public override string ToString()
        {
            return

        }
    }
}
