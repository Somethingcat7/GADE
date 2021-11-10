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
        
        public Hero(int x, int y) : base(x, y, Tile.TileType.Hero,'H', 2, 10,10)
        {
           
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
            string Info = "Player Stats: \n";
            Info += "Hp: " + Health.ToString() + "/" + MaxHealth.ToString() + "\n";
            Info += "Damage: " + Damage.ToString() + "\n";
            Info += "Gold: " + GoldAmount.ToString() + "\n";
            Info += "[" + x.ToString() + "," + y.ToString() + "]";
            return Info;
        }

        bool CheckValidMove(MovementEnum Charactermove)
        {
            bool IsValid = false;

            switch (Charactermove)
            {
                case MovementEnum.Right:
                    foreach (Tile T in Vision)
                    { 
                        if (T.getx == x + 1)
                        {
                            if (T.Tiletyping == TileType.Empty)
                            {
                                IsValid = true;
                                break;
                            }
                        }
                    }
                    break;

                case MovementEnum.Left:
                    foreach (Tile T in Vision)
                    {
                        if (T.getx == x + 1)
                        {
                            if (T.Tiletyping == TileType.Empty)
                            {
                                IsValid = true;
                                break;
                            }
                        }
                    }
                    break;

                case MovementEnum.Up:
                    foreach (Tile T in Vision)
                    {
                        if (T.getx == x + 1)
                        {
                            if (T.Tiletyping == TileType.Empty)
                            {
                                IsValid = true;
                                break;
                            }
                        }
                    }
                    break;

                case MovementEnum.Down:
                    foreach (Tile T in Vision)
                    {
                        if (T.getx == x + 1)
                        {
                            if (T.Tiletyping == TileType.Empty)
                            {
                                IsValid = true;
                                break;
                            }
                        }
                    }
                    break;

                    
            }
            
            return IsValid;
        }
    }
}
