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
        protected int GoldAmount;
        protected string TileTyping;
        private Tile[] vision;
        private Enums.MovementEnum movement;

        //Accessor for variables Health, MaxHealth, Damage, Tile Type, Vision and Movement
        public int gethealth { set { Health = value; } get { return Health; } }
        public int getMaxHealth { set { MaxHealth = value; } get { return MaxHealth; } }
        public int getDamage { set { Damage = value; } get { return Damage; } }
        public string getType { set { TileTyping = value; } get { return TileTyping; } }
        public int getGoldAmount { set{ GoldAmount = value; } get{ return GoldAmount; } }
        public Tile[] Vision { set { vision = value; } get { return vision; } }
        public Enums.MovementEnum MOVEMENT {set { movement = value; } get { return movement; }}

        /*private int distanceTo() 
        { 

        }*/

        //Set values for variables
        protected Character(int x, int y, Enums.TileType tiletype, char symbol, int health, int maxHealth, int damage) : base(x, y, symbol)
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
        
        private int DistanceTo(Character Target)
        {
            int calcDistance(int origin, int destination)
            {
                int distance = destination - origin;
                return Math.Abs(distance);
            }

            return (calcDistance(this.x, Target.x) + calcDistance(this.y, Target.y));
        }

        public virtual bool CheckRange(Character Target)
        { 
            if (DistanceTo(Target) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public abstract Enums.MovementEnum ReturnMove(Enums.MovementEnum x);

        public abstract override string ToString();

        //Hero vision array
        Tile[] VisionArray = new Tile[4];

        public void Pickup(Item i)
        {
           
        }
    }
}
