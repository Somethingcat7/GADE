using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
   
    
        //Tile types
        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Item,
            Weapon,
            Obstacle,
            Shop,
            Empty
        }
        //Movements
        public enum MovementEnum
        {
            Up,
            Down,
            Left,
            Right,
            NoMovement
        }

        public enum WeaponTypes
        {
            Dagger,
            Longsword,
            Rifle,
            LongBow,
            BareHands
        }
    }

