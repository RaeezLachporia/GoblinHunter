using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    class GameEngine : Map
    {
        public GameEngine(int _X, int _Y, TileType _TOT, int _Damage, int _MAXHP, int _mapMinHGHT, int _mapMaxHGHT, int _mapMinWDTH, int _mapMaxWDTH) : base(_X, _Y, _TOT, _Damage, _MAXHP, _mapMinHGHT, _mapMaxHGHT, _mapMinWDTH, _mapMaxWDTH)
        {
        }
    }
}
