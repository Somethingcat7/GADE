using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class Gold : Item
    {
        private int goldvalue;
        
        Random RanDum = new Random();
        /*private int GoldAmount(int min, int max)
        {
            return RanDum.Next(min,max);
        }*/

        public int GoldValue { set { goldvalue = value; } get { return goldvalue; } }
        
        public Gold(int x, int y, TileType tile_type) : base(x, y, tile_type, '$')
        {
            goldvalue = RanDum.Next(1, 6);
          
        }

        public override string ToString()
        {
            string Info = "\n";
            return Info;
        }

    }
}
