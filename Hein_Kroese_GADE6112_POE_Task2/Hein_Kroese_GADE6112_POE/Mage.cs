using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class Mage : Enemy 
    {   //Mage constructor
        public Mage(int x, int y) : base(x, y, Enums.TileType.Enemy, 'M', 5, 5, 5)
        {

        }

        public override Enums.MovementEnum ReturnMove(Enums.MovementEnum move = Enums.MovementEnum.None)
        {
           return Enums.MovementEnum.None;
        }

        public override bool CheckRange(Character Target)
        {
            if (Target.getx == x + 1 && Target.gety == y)
            {
                return true;
            }
            else if (Target.getx == x - 1 && Target.gety == y)
            {
                return true;
            }
            else if (Target.getx == x && Target.gety == y + 1)
            {
                return true;
            }
            else if (Target.getx == x && Target.gety == y - 1)
            {
                return true;
            }
            else if (Target.getx == x - 1 && Target.gety == y - 1)
            {
                return true;
            }

            else if (Target.getx == x - 1 && Target.gety == y + 1)
            {
                return true;
            }

            else if (Target.getx == x + 1 && Target.gety == y - 1)
            {
                return true;
            }

            else if (Target.getx == x + 1 && Target.gety == y + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
