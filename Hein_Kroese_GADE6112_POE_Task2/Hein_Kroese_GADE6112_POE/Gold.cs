using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class Gold : Item
    {
        protected Gold(int x, int y, char symbol): base (x,y,symbol)
        {

        }
        public override string ToString()
        {
            return null;
        }

        private Random RanDumb = new Random();
    }
}
