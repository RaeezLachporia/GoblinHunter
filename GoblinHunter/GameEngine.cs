using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    class GameEngine : Map
    {
        private Map game;

        public Map Game
        {
            get { return game; }
            set { game = value; }
        }

        public bool movePlayer(Movement movement)
        {
            return
        }
        public GameEngine(int _X, int _Y, TileType _TOT, int _Damage, int _MAXHP, int _mapMinHGHT, int _mapMaxHGHT, int _mapMinWDTH, int _mapMaxWDTH) : base(_X, _Y, _TOT, _Damage, _MAXHP, _mapMinHGHT, _mapMaxHGHT, _mapMinWDTH, _mapMaxWDTH)
        {
            game = new Map();

        }

        public char enemy = 'G';
        public char Hero = 'H';
        public char Obstacle = 'X';
        public char emptyTile = '.';

    }
}
