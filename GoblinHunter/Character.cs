using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    abstract class Character : Tile
    {
        Tile[] charVision = new Tile[4];
        private int hp;
        String Symbol;
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

        public enum Movement
        {
            noMovement,
            Up,
            Down,
            Left,
            Right
        }

        public virtual void Attack()
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

       

        private int DistancTo()
        {
            int distanceToTarget = 0;
            return distanceToTarget;
        }
        
        public void Move(Movement move)
        {
            
        }

        public abstract  (Movement move = 0)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }


    }
}
