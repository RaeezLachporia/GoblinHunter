using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    abstract class Item : Tile
    {
        protected Item(int _X, int _Y, TileType _TOT, string _Symbol) : base(_X, _Y, _TOT, _Symbol)
        {
           
        }

        
    }
    
}
