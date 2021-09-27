using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class Map
    {   //Map size
        private int minHeight;
        private int minWidth;
        private int maxHeight;
        private int maxWidth;
        private int numEnemies;

        //Map array
        private char[,] mapXY;

        //Player Variable
        private Hero Player;

        //Enemy array
        private char[] Enemies;

        //Random number generator
        private Random RanDumb = new Random();
        public int Coords(int min, int max)
        {
            return RanDumb.Next(min, max);
        }

        public Map(int MinHeight, int MinWidth, int MaxHeight, int MaxWidth, int NumEnemies)
        {
            minHeight = MinHeight;
            minWidth = MinWidth;
            maxHeight = MaxHeight;
            maxWidth = MaxWidth;
            numEnemies = NumEnemies;
        }

        public void updateMap()
        {
            mapXY = new char[maxHeight, maxWidth];
        }

        private Tile create(Tile.TileType MakingOfTile)
        {
            for (int i = 0; i < Coords(2,16); i++)
            {
                for (int j = 0; j < Coords(2, 16); j++)
                {
                    mapXY[i, j] = '.';
                }
            }

            switch(MakingOfTile)
            {
                case Tile.TileType.Hero:
                    return new Hero(2, 2, 'H', 15, 15, 3, 3);
               
                case Tile.TileType.Enemy:
                    return new Goblin(2, 2, 'G', 10, 10, 1);

               /* case Tile.TileType.Obstacle:
                    return new Obstacle();

                case Tile.TileType.Empty:
                    return new EmptyTile();

                    
                     case Tile.TileType.Gold:
                        return new "Gold"

                     case Tile.TileType.Weapon:
                        return new "Weapon"
                     */

            }
             return null;
        }

        public override string ToString()
        {
            return null;              
        }
    }
}
