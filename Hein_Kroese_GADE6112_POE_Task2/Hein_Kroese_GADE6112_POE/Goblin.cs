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
        public Goblin(int x, int y) : base(x, y,TileType.Enemy, 'G', 5, 5, 2)
        {
     
        }

        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.None)
        {
            int randomtileindex = RanNum.Next(0, Vision.Length);

            while (Vision[randomtileindex].getsymbol.Equals(typeof(EmptyTile)))
            {
                randomtileindex = RanNum.Next(0, Vision.Length);
            }

            if (Vision[randomtileindex].getx > x)
            {
                return MovementEnum.Right;
            }
            else if (Vision[randomtileindex].getx < x)
            {
                return MovementEnum.Left;
            }
            else if (Vision[randomtileindex].gety < y)
            {
                return MovementEnum.Up;
            }
            else if (Vision[randomtileindex].gety > y)
            {
                return MovementEnum.Down;
            }

            return MovementEnum.None;
        }

        public override string ToString()
        {
            return "Goblin at: [" + x.ToString() + ", " + y.ToString() + "] " +  Damage.ToString();
        }


    }
}
