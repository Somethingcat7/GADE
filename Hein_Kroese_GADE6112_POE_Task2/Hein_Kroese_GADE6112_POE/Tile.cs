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
            Item,
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
    }
}
    

   
