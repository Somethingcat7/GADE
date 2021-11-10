using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    abstract class Tile
    {   //Variables
        protected int x;
        protected int y;
        protected char symbol;
        //Accessors for x, y and symbol
        public int getx { set { x = value; } get { return x; } }
        public int gety { set { y = value; } get { return y; } }
        public char getsymbol { set { symbol = value; } get { return symbol; } }
        public TileType Tiletyping { set { Tiletyping = value; } get { return Tiletyping; } }
              
        protected Tile(int x, int y ,char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        //Tile types
        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon,
            Obstacle,
            Empty
        }
        //Movements
        public enum MovementEnum
        {
            Up,
            Down,
            Left,
            Right,
            None
        }

        //Code for tyle types
        public void ExampleMethod(TileType input)
        {
            switch (input)
            {
                case TileType.Hero:
                    //Code for hero tile here
                    break;

                case TileType.Enemy:
                    //Code for enemy tile here
                    break;

                case TileType.Gold:
                    //Code for gold tile here
                    break;

                case TileType.Weapon:
                    //Code for weapon tile here
                    break;

                case TileType.Obstacle:
                    //code for obstacle tile here
                    break;

                case TileType.Empty:
                    //code for empty tile here
                    break;

            }
        }          
    }
}
    

   
