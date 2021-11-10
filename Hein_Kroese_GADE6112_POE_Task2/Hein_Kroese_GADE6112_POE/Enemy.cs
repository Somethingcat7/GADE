using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    //Subclass Enemy to class Character
    abstract class Enemy : Character
    {
        protected Random RanNum = new Random();

        protected Enemy(int x, int y, Enums.TileType TileType, char symbol, int health, int maxHP, int damage) : base(x, y, TileType , symbol, health, maxHP, damage)
        {
            this.Health = health;
            this.MaxHealth = maxHP;
            this.Damage = damage;

        }

        public int Coords(int min, int max)
        {
            return RanNum.Next(min, max);
        }
        
       /* public Enemy(int x, int y,TileType tiletype ,char symbol, int health, int maxHealth, int damage) : base(x, y, tiletype, symbol, health, maxHealth, damage)
        {

        }*/

        public override Enums.MovementEnum ReturnMove(Enums.MovementEnum move = Enums.MovementEnum.None)
        {
            return Enums.MovementEnum.None;
        }

        

        public override void Attack(Character target)
        {
            target.gethealth = target.gethealth - 5;
        }

        public override string ToString()
        {
            string Info = TileTyping + "\n";
            Info += "at ["+ x.ToString() + "," + y.ToString() + "] \n";
            Info += Health.ToString() + "Hp \n";
            Info += "(" + Damage.ToString() + ")";
            return Info;
        }

    }
}