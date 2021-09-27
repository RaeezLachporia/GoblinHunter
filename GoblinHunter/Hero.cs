﻿using System;
using System.Collections.Generic;
using System.Text;
using static GoblinHunter.Character;

namespace GoblinHunter
{
     class Hero : Character
    {
        //declaring the variables for the class
        int X, Y;
        private int hp;
        char heroSymbol;
        String info;

        //declaring the getters and setters for the hp, max hp and hero damage 
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        private int maxhp;

        public int MAXHP
        {
            get { return maxhp; }
            set { maxhp = value; }
        }

        private int heroDamage;

        public int HERODAMAGE
        {
            get { return heroDamage; }
            set { heroDamage = value; }
        }
        
        
        //declaring the constructors and pulling the different variables 
        public Hero(int _X, int _Y, TileType _TOT,int _HP,int _MaxHP,int _heroDamage,char _hSymbol) : base(_X, _Y, _TOT)
        {
            X = _X;
            Y = _Y;
            MAXHP = _MaxHP;
            HP = _HP;
            heroDamage = 2;
            heroDamage = _heroDamage;
            _hSymbol = heroSymbol;

        }
        public override Movement ReturnMove(Movement move = noMovement)
        {
            
        }
        /*public override RetrunMove()
        {

        }*/
        //this method displayss the information related to this class
        public override string ToString()
        {
            info += "Player Stats:";
            info += "HP:" + "MaxHp:";
            info += "Damage: " + heroDamage;
            return info;
        }

    }

}
