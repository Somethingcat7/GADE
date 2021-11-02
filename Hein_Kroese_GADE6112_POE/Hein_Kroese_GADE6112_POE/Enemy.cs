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

        public int Coords(int min, int max)
        {
            return RanNum.Next(min, max);
        }
        
        public Enemy(int x, int y, char symbol, int health, int maxHealth, int damage) : base(x, y, symbol, health, maxHealth, damage)
        {

        }

        public override MovementEnum ReturnMove()
        {
            return MovementEnum.None;
        }

        

        public override void Attack(Character target)
        {
            target.gethealth = target.gethealth - 5;
        }
    }
}
