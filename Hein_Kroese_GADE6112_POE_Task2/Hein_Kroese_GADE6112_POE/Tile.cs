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
        protected TileType TypeOfTile;
        //Accessors for x, y and symbol
        public int getx { set { x = value; } get { return x; } }
        public int gety { set { y = value; } get { return y; } }
        public char getsymbol { set { symbol = value; } get { return symbol; } }
        public TileType Tiletyping { set { TypeOfTile = value; } get { return TypeOfTile; } }
              
        protected Tile(int X, int Y, TileType tile_type, char Symbol)
        {
            x = X;
            y = Y;
            symbol = Symbol;
            TypeOfTile = tile_type;
        }

             
    }
}
    

   
