﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class Obstacle : Tile
    {
        public Obstacle(int x, int y, TileType tile_type) : base(x, y, tile_type, 'X')
        {
            
        }
    }
}
