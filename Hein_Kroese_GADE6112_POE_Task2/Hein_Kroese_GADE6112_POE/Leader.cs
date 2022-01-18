using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class Leader : Enemy
    {

        Hero hero = new Hero(1,1);

        public Leader(int x, int y) : base(x, y, TileType.Enemy, 'L', 20, 20, 2, 2)
        {
          
        }
        

        public bool CheckValidMove(MovementEnum Charactermove)
        {
            {
                bool valid = false;

                switch (Charactermove)
                {
                    case MovementEnum.Right:
                        if (vision[2].GetType() == typeof(EmptyTile) || vision[2].GetType() == typeof(Gold))
                        {
                            valid = true;
                            break;
                        }
                        break;
                    case MovementEnum.Left:
                        if (vision[3].GetType() == typeof(EmptyTile) || vision[3].GetType() == typeof(Gold))
                        {
                            valid = true;
                            break;
                        }
                        break;
                    case MovementEnum.Down:
                        if (vision[1].GetType() == typeof(EmptyTile) || vision[1].GetType() == typeof(Gold))
                        {
                            valid = true;
                            break;
                        }
                        break;
                    case MovementEnum.Up:
                        if (vision[0].GetType() == typeof(EmptyTile) || vision[0].GetType() == typeof(Gold))
                        {
                            valid = true;
                            break;
                        }
                        break;
                }
                return valid;
            }
        }
        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.NoMovement)
        {
            if (CheckValidMove(move))
            {
                if (x > hero.getx)
                {
                    return MovementEnum.Left;
                }

            else if (x < hero.getx)
            {
                return MovementEnum.Right;
            }
            else if (y > hero.gety)
            {
                return MovementEnum.Up;
            }
            else if (y < hero.gety)
            {
                return MovementEnum.Down;
            }
            else
            {
                return MovementEnum.NoMovement;
            }   
           
            }
           else return MovementEnum.NoMovement;
 
        }

    }
}
