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

        protected Enemy(int x, int y, TileType TileType, char symbol, int health, int maxHP, int damage, int goldAmount) : base(x, y, TileType , symbol, health, maxHP, damage, goldAmount)
        {
            Health = health;
            MaxHealth = maxHP;
            Damage = damage;


        }

        public int Coords(int min, int max)
        {
            return RanNum.Next(min, max);
        }

        bool CheckValidMove(MovementEnum charactermove)
        {
            bool valid = false;

            switch (charactermove)
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

        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.NoMovement)
        {
            if (CheckValidMove(move))
            {
                return move;
            }
            else return MovementEnum.NoMovement;
        }

        public override void Attack(Character target)
        {
            target.gethealth = target.gethealth - 5;
        }

        public override string ToString()
        {
            string Info = TileTyping + "\n";
            Info += "at ["+ x.ToString() + "," + y.ToString() + "] \n";
            Info += Health.ToString() + "Hp \n";
            Info += "(" + Damage.ToString() + ")";
            return Info;
        }

    }
}