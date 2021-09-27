using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class GameEngine
    {
        public Map gameMap = new Map(5, 10, 5, 10, 5);

        public void updateGame()
        {
            gameMap.updateMap();
        }
    }
}
