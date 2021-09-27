﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GoblinHunter
{
    class Hero : Character
    {

        int X, Y;
        private int hp;
        String info;
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


        public Hero(int _X, int _Y, TileType _TOT,int _HP,int _MaxHP,int _heroDamage) : base(_X, _Y, _TOT)
        {
            X = _X;
            Y = _Y;
            MAXHP = _MaxHP;
            HP = _HP;
            heroDamage = 2;
            heroDamage = _heroDamage;
        }

        /*public override RetrunMove()
        {

        }*/
        public override string ToString()
        {
            info += "Player Stats:";
            info += "HP:" + "MaxHp:";
            info += "Damage: " + heroDamage;
            return info;
        }

    }

}