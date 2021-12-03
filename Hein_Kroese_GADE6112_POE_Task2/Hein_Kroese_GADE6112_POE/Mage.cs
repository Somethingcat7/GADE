using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class Mage : Enemy 
    {   //Mage constructor
        public Mage(int x, int y) : base(x, y, TileType.Enemy, 'M', 5, 5, 5)
        {

        }

        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.None)
        {
           return MovementEnum.None;
        }

        public override bool CheckRange(Character Target)
        {
            return base.CheckRange(Target);
        }

    }
}
