﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    abstract class Character : Tile
    {   //Variables
        protected int Health;
        protected int MaxHealth;
        protected int Damage;
        protected string TileTyping;
        private Tile[] vision;
        private MovementEnum movement;

        //Accessor for variables Health, MaxHealth, Damage, Tile Type, Vision and Movement
        public int gethealth { set { Health = value; } get { return Health; } }
        public int getMaxHealth { set { MaxHealth = value; } get { return MaxHealth; } }
        public int getDamage { set { Damage = value; } get { return Damage; } }
        public string getType { set { TileTyping = value; } get { return TileTyping; } }
        public Tile[] Vision { set { vision = value; } get { return vision; } }
        public MovementEnum MOVEMENT {set { movement = value; } get { return movement; }}

        /*private int distanceTo() 
        { 

        }*/

        //Set values for variables
        protected Character(int x, int y, TileType tiletype, char symbol, int health, int maxHealth, int damage) : base(x, y, symbol)
        {
            this.Health = health;
            this.MaxHealth = maxHealth;
            this.Damage = damage;

            
        }

        //Method for character attack
        public virtual void Attack(Character target)
        {
            target.Health -= Damage;
        }

        public bool isDead(int Helf) 
        { 
          bool Dieded;

            
            if (Helf <= 0) 
            {
              Dieded = true;
            } 
            else
            {
               Dieded = false;
            }
            
            return Dieded;
        }
        
        /*public virtual bool CheckRange(Character Target)
        { 

        }*/
        public abstract MovementEnum ReturnMove();

        public abstract override string ToString();

        //Hero vision array
        Tile[] VisionArray = new Tile[4];
    }
}
