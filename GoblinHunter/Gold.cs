using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    class Gold : Item
    {
        public Gold(int _X, int _Y, TileType _TOT, string _Symbol) : base(_X, _Y, _TOT, _Symbol)
        {
            rndGold.Next(1, 6); 
        }

        private int gold;

        public int GOLD
        {
            get { return gold; }
            set { gold = value; }
        }
        private Random rndGold = new Random();



    }
}
