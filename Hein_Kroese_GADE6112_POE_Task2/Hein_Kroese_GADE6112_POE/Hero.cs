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

        public Hero(int x, int y) : base(x, y, TileType.Hero, 'H', 2, 10, 10, 0)
        {

        }

        public override void Attack(Character target)
        {
            target.gethealth = target.gethealth - 5;
        }

        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.NoMovement)
        {
            return MovementEnum.NoMovement;
        }

        public override string ToString()
        {
            string Info = "Player Stats: \n";
            Info += "Hp: " + Health.ToString() + "/" + MaxHealth.ToString() + "\n";
            Info += "Damage: " + Damage.ToString() + "\n";
            Info += "Gold: " + GoldAmount.ToString() + "\n";
            Info += "[" + x.ToString() + "," + y.ToString() + "]";
            return Info;
        }

        bool CheckValidMove(MovementEnum Charactermove)
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
    }
}
