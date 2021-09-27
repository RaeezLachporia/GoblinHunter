using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    abstract class Enemy : Character
    {
        //declaring the variables for the enemy class
        public Random rnd = new Random();
        public String EnemyClassName = " ";
        private int damage;

        //declaring th egetters and setters for the damage and maxhp for the class
        public int DAMAGE
        {
            get { return damage; }
            set { damage = value; }
        }

        private int maxHp;

        public int MAXHP
        {
            get { return maxHp; }
            set { maxHp = value;}
        }

        public override string ToString()
        {
            return;

        }
    }
}
