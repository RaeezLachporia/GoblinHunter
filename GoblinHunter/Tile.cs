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

        private String symbol;

        public String Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }


        public Tile(int _X,int _Y,TileType _TOT,String _Symbol)
        {
            X = _X;
            Y = _Y;
            TOT = _TOT;
            Symbol = _Symbol;

        }
    }
}
