using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    //Subclass Goblin to class Enemy
    class Goblin : Enemy
    {
        public Goblin(int x, int y, char symbol, int health, int maxHealth, int damage) : base(x, y, 'G', 10, 10, 1)
        {
            this.x = Coords(2, 15);
            this.y = Coords(2, 15);
        }

        public override MovementEnum ReturnMove()
        {
            return MovementEnum.None;
        }

        public override string ToString()
        {
            return "Goblin at: [" + x.ToString() + ", " + y.ToString() + "] " +  Damage.ToString();
        }

    }
}
