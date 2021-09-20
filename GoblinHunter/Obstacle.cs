using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    class Obstacle : Tile
    {
        public Obstacle(int _X, int _Y, TileType _TOT) : base(_X, _Y, _TOT)
        {
        }

        public int ObstacleX()
        {
            return base.X;
        }

        public int ObstacleY()
        {
            return base.Y;
        }
        


    }
}
