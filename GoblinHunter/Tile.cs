using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{

    public enum TileType 
    {
        Hero,
        Enemy,
        Gold,
        Weapon,
    }

    abstract class Tile
    {
        protected int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        protected int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        private TileType tot;

        public TileType TOT
        {
            get { return tot; }
            set { tot = value; }
        }

        

        public Tile(int _X,int _Y,TileType _TOT)
        {
            X = _X;
            Y = _Y;
            TOT = _TOT;

        }
    }
}
