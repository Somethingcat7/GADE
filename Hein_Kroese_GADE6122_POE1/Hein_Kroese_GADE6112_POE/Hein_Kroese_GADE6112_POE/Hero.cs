using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    //Subclass Player to class Character
    class Hero : Character
    {
        int movementSpeed;
        public Hero(int x, int y, char symbol, int health, int maxHealth, int damage, int movespeed) : base(x, y, 'H', 20, 20, 2)
        {
            this.movementSpeed = movespeed;
        }

        public override void Attack(Character target)
        {
            target.gethealth = target.gethealth - 5;
        }

        public override MovementEnum ReturnMove()
        {
            return MovementEnum.None;
        }

        public override string ToString()
        {
            return "Player stats: " + Environment.NewLine + "HP: " + Health.ToString() + "/" + MaxHealth.ToString() + Environment.NewLine + "Damage: " + Damage.ToString() + Environment.NewLine + "[" + x.ToString() + "," + y.ToString() + "]";
        }
    }
}
