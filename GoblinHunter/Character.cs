using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    abstract class Character : Tile
    {
        protected Tile[] charVision = new Tile[4];
        protected int hp;
        protected String Symbol;
        protected int maxHp;
        protected Movement movement;
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        private int maxhp;

        public int MaxHp
        {
            get { return maxhp; }
            set { maxhp = value; }
        }

        private int damage;

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

       

        protected Character(int _X, int _Y, TileType _TOT) : base(_X, _Y, _TOT)
        {

        }

        protected enum Movement
        {
            noMovement,
            Up,
            Down,
            Left,
            Right
        }

        public virtual void Attack(Character _Target)
        {

        }

        public Boolean isDead()
        {
            Boolean isDead = false;
            return isDead;
        }
        public virtual bool checkRange()
        {
            int Range = 1;
            Boolean inRange = false;
            return inRange;
        }

       

        private int DistancTo(Character _Target)
        {
            int distanceToTarget = 0;
            return distanceToTarget;
        }
        
        public void Move(Movement move)
        {
            
        }

         /*public abstract Movement  (Movement move = 0)
        {
           
        }
        /*public abstract override String ToString()
        {

            return Character.ToString();
        }*/


    }
}
