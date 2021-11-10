using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class Enums
    {
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
