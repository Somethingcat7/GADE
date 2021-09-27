using System;
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

        //Accessor for variables Health, MaxHealth and Damage
        public int gethealth { set { Health = value; } get { return Health; } }
        public int getMaxHealth { set { MaxHealth = value; } get { return MaxHealth; } }
        public int getDamage { set { Damage = value; } get { return Damage; } }

        /*private int distanceTo() 
        { 

        }*/

        //Set values for variables
        protected Character(int x, int y, char symbol, int health, int maxHealth, int damage) : base(x, y, symbol)
        {
            this.Health = health;
            this.MaxHealth = maxHealth;
            this.Damage = damage;
        }

        //Method for character attack
        public virtual void Attack(Character target)
        {
            //
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
