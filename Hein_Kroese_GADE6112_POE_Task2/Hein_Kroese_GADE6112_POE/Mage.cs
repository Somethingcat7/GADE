using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class Mage : Enemy 
    {
        public Mage(int x, int y, TileType tileType, char symbol = 'M', int health = 5, int maxHealth = 5, int damage = 5) : base(x, y, tileType, symbol, health, maxHealth, damage)
        {

        }
    }
}
