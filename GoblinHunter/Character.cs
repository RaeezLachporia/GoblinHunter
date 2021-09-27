using System;
using System.Collections.Generic;
using System.Text;
using static GoblinHunter.Tile

namespace GoblinHunter
{
    public abstract class Character : Tile
    {
        protected Tile[] charVision;
        protected int hp;
        protected String Symbol;
        protected int maxHp;
        protected Movement movement;
        public int up = 1;
        public int right = 2;
        public int down = 3;
        public int left = 4;
        public int X,Y

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

       public Character(int _X, int _Y, TileType _TOT, string _Symbol) : base(_X, _Y, _TOT, _Symbol)
        {
            _X = X;
            _Y = Y;
        }

        public Character(int _X, int _Y, TileType _TOT, string _Symbol,int _Hp, int _maxHp,int _Damage) : base(_X, _Y, _TOT, _Symbol)
        {
            Hp = _Hp;
            maxHp = _maxHp;
            Damage = _Damage;
            charVision = new Tile[4];
        }
        

        public enum Movement
        {
            noMovement,
            Up,
            Down,
            Left,
            Right
        }

        public virtual void Attack(Character _Target)
        {
            _Target.hp -= damage;
        }

        public Boolean isDead()
        {
            Boolean isDead = false;
            if(hp <= 0)
            {
                return isDead;
            }
            else
            {
                return true;
            }
            
        }
        public virtual bool checkRange(Character _Target)
        {
            int Range = 1;
            Boolean inRange = false;
            if(DistanceTo(_Target) < Range)
            {
                return true;
            }
            else
            {
                return inRange;
            }
            return inRange;
        }

       

        private int DistanceTo()
        {
            int distanceToTarget = 0;
            
            return distanceToTarget;
        }
        
        public void Move(Movement move)
        {
            if(move == Movement.Up)
            {
                Y+=1;
            }
            else if(move == Movement.Right)
            {
                X += 1 
            }
            else if (move == Movement.Down)
            {
                Y -= 1
            }
            else if (move == Movement.Left)
            {
                X -= 1;
            }
        }

        /*public abstract Movement  (Movement move = 0)
       {

       }
       /*public abstract override String ToString()
       {

           return Character.ToString();
       }*/

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
