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
        public Tile[] vision = new Tile[4];
        private MovementEnum movement;

        //Accessor for variables Health, MaxHealth, Damage, Tile Type, Vision and Movement
        public int gethealth { set { Health = value; } get { return Health; } }
        public int getMaxHealth { set { MaxHealth = value; } get { return MaxHealth; } }
        public int getDamage { set { Damage = value; } get { return Damage; } }
        public string getType { set { TileTyping = value; } get { return TileTyping; } }
        public int getGoldAmount { set{ GoldAmount = value; } get{ return GoldAmount; } }
        public Tile[] Vision { set { vision = value; } get { return vision; } }
        public MovementEnum MOVEMENT {set { movement = value; } get { return movement; }}

        private int distanceTo(Character character) 
        {
            int num = x + y;
            int num2 = character.x + character.y;
            int num3 = Math.Abs(num - num2);
            return num3;
        }

        //Set values for variables
        public Character(int x, int y, TileType tile_type, char symbol, int health, int maxHealth, int damage, int goldAmount) : base(x, y, tile_type, symbol)
        {
            Health = health;
            MaxHealth = maxHealth;
            Damage = damage;
            GoldAmount = goldAmount;
                       
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
            int num = x + y;
            int num2 = Target.x + Target.y;
            int num3 = Math.Abs(num - num2);
            return num3;
        }

        public virtual bool CheckRange(Character Target)
        { 
            if (DistanceTo(Target) > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public abstract MovementEnum ReturnMove(MovementEnum x);

        public abstract override string ToString();

        //Hero vision array
        Tile[] VisionArray = new Tile[4];

        public void Pickup(Item i)
        {
            Gold gold = (Gold)i;
            GoldAmount = GoldAmount + gold.GoldValue;
        }

        public void Move(MovementEnum move)
        {
            switch (move)
            {
                case MovementEnum.Up:
                    y = y - 1;
                    break;
                case MovementEnum.Down:
                    y = y + 1;
                    break;
                case MovementEnum.Left:
                    x = x - 1;
                    break;
                case MovementEnum.Right:
                   x = x + 1;
                    break;
                case MovementEnum.NoMovement:
                    break;
            }
        }
    }
}
