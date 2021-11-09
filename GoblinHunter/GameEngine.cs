﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    class GameEngine : Map
    {
        Map mp = new Map();
        
        // declaring the getters and the setter for the values used in the class
        private Map game;

        public Map Game
        {
            get { return game; }
            set { game = value; }
        }
        //this method moves the player 
        public bool movePlayer(Movement movement)
        {
            return;
        }

        public Map(int _EnemyX, int _EnemyY, String _ESYMBOL, TileType _TOT, int _MINWIDTH, int _MAXWIDTH, int _MINHEIGHT, int _MAXHEIGHT, int _NUMBEROFENEMIES) : base()
        {
            
        }
        //declaring the constructor and pulling the variables that are neccessary in this class
        public GameEngine(int _X, int _Y, TileType _TOT, int _Damage, int _MAXHP, int _mapMinHGHT, int _mapMaxHGHT, int _mapMinWDTH, int _mapMaxWDTH) : base(_X, _Y," ", _TOT, _mapMinHGHT, _mapMaxHGHT, _mapMinWDTH, _mapMaxWDTH,0)
        {
            


        }

        public void Save()
        {
            
        }
        //sets the symbols for the player, goblin, obstacles and empty tiles 
        public char enemy = 'G';
        public char Hero = 'H';
        public char Obstacle = 'X';
        public char emptyTile = '.';

    }
}
