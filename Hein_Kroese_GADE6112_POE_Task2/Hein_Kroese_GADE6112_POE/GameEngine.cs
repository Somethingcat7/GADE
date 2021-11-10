using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class GameEngine
    {
        //Charactermachurs
        private static char HeroBoi = 'H';
        private static char EmptySpace = '.';
        private static char Obsticle = 'X';
        private static char GoblinyBoi = 'G';

        private Map MappyBoi;

        public Map MappyGurl { set { MappyBoi = value; } get { return MappyBoi; } }


        public GameEngine()
        {
            MappyBoi = new Map(7, 14, 7, 14, 4);
        }

        //It does all of the things :D
        public override string ToString()
        {
            string MapStringy = string.Empty;
            char[,] MapChar = new char[MappyBoi.Width, MappyBoi.Height];

            for (int i = 0; i < MappyBoi.Width; i++)
            {
                for (int j = 0; j < MappyBoi.Height; j++)
                {
                    if (MappyBoi.Tilemappy[i, j].GetType() == typeof(Obstacle))
                    {
                        MapChar[i, j] = Obsticle;
                    }

                    if (MappyBoi.Tilemappy[i, j].GetType() == typeof(Goblin))
                    {
                        MapChar[i, j] = GoblinyBoi;
                    }

                    if (MappyBoi.Tilemappy[i, j].GetType() == typeof(Hero))
                    {
                        MapChar[i, j] = HeroBoi;
                    }

                    if (MappyBoi.Tilemappy[i, j].GetType() == typeof(EmptyTile))
                    {
                        MapChar[i, j] = EmptySpace;
                    }

                    MapStringy += MapChar[i, j];
                }
                MapStringy += "\n";
            }
            return $"{MapStringy}";

        }

    }
}

