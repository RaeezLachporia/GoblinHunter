using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    class Obstacle : Tile
    {
        //declaring the constructors for the obstacle class 
        public Obstacle(int _X, int _Y, TileType _TOT, string _Symbol) : base(_X, _Y, _TOT, _Symbol)
        {
            X = _X;
            Y = _Y;
            TOT = _TOT;
        }

       public int ObstacleX()
        {
            return base.X;
        }

        public int ObstacleY()
        {
            return base.Y;
        }//



    }
}
