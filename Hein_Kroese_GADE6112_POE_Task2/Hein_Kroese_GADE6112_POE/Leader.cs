using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class Leader : Enemy
    {

        public Leader(int x, int y) : base(x, y, TileType.Enemy, 'L', 20, 20, 2, 0)
        {

        }

        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.NoMovement)
        {
            return base.ReturnMove(move);
        }

    }
}
