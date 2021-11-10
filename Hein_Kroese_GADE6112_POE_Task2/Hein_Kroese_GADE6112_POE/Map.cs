using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class Map
    {   //Map size
        private int mapLong;
        private int mapWide;
        
        //Amount of bad peoples
        private int enemynumber;
        
        //Accessors cause yeah, real helpful
        public Hero Player { set{ player = value; } get{ return player; } }  
        public int enemynum { set{ enemynumber = value; } get{ return enemynumber; } }
        public int Width { set { mapWide = value; } get { return mapWide; } }
        public int Height { set { mapLong = value; } get { return mapLong; } }
        public Tile[,] Tilemappy { set { theMap = value; } get { return theMap; } } 

        
        //Arry things
        private Tile[,] theMap;
        private Enemy[] arrayofenemies;
        
        //Player Variable
        private Hero player;
               
        //Random number generator
        private Random RanDumb = new Random();

        public Map(int MinHeight, int MinWidth, int MaxHeight, int MaxWidth, int NumEnemies)
        {   
            Random RanDum = new Random();
            
            mapLong = RanDum.Next(MinHeight,MaxHeight);
            mapWide = RanDum.Next(MinWidth, MaxWidth);         
           

            theMap = new Tile[mapWide,mapLong];

            arrayofenemies = new Enemy[enemynumber];

            FillMap();

            Player = (Hero)create(Tile.TileType.Hero);
            theMap[player.getx, player.gety] = player;

            for (int i = 0; i < arrayofenemies.Length; i++)
            {
                arrayofenemies[i] = (Enemy)create(Tile.TileType.Enemy);
            }

            UpdateVision();
        }
        //Update the map dumbo
        public void updateMap()
        {
            FillMap();
            theMap[Player.getx, Player.gety] = Player;

            for (int i = 0; i < arrayofenemies.Length; i ++)
            {
                theMap[arrayofenemies[i].getx, arrayofenemies[i].gety] = arrayofenemies[i];
            }

            UpdateVision();
        }
        
        public Tile[,] Mappymap { set { theMap = value; } get { return theMap; } }
       
        //Create the tiles, it's litteraly in the name
        private Tile create(Tile.TileType MakingOfTile)
        {
            Random RanDum = new Random();
            int RNGX;
            int RNGY;

            bool IsTileOpen(int x, int y)
            {
                if (theMap[x,y].GetType() != typeof(EmptyTile))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            switch(MakingOfTile)
            {
                case Tile.TileType.Hero:
                    do
                    {
                        RNGX = RanDum.Next(1, theMap.GetLength(0));
                        RNGY = RanDum.Next(1, theMap.GetLength(1));
                    } while (IsTileOpen(RNGX,RNGY));

                    return new Hero(RNGX, RNGY);
               
                case Tile.TileType.Enemy:
                    do
                    {
                        RNGX = RanDum.Next(1, theMap.GetLength(0));
                        RNGY = RanDum.Next(1, theMap.GetLength(1));
                    } while (IsTileOpen(RNGX, RNGY));

                    return new Goblin(RNGX, RNGY);

                /* case Tile.TileType.Obstacle:
                     return new Obstacle();

                 case Tile.TileType.Empty:
                     return new EmptyTile();

                 case Tile.TileType.Gold:
                     return new "Gold"

                 case Tile.TileType.Weapon:
                     return new "Weapon"
                      */

                default:
                 return null;
            }
        
        }

        public override string ToString()
        {
            return null;              
        }
        //Improve your eyes stupid
        public void UpdateVision()
        {
            /*player.Vision[0] = theMap[player.getx - 1, player.gety];
            player.Vision[1] = theMap[player.getx + 1, player.gety];
            player.Vision[1] = theMap[player.getx, player.gety - 1];
            player.Vision[1] = theMap[player.getx, player.gety + 1];*/

            foreach (Enemy enemy in arrayofenemies)
            {
                enemy.Vision[0] = theMap[enemy.getx - 1, enemy.gety];
                enemy.Vision[1] = theMap[enemy.getx + 1, enemy.gety];
                enemy.Vision[2] = theMap[enemy.getx, enemy.gety - 1];
                enemy.Vision[3] = theMap[enemy.getx, enemy.gety + 1];
            }

        }
        //MAKE MAP YOU DUMB DUMB
        public void FillMap()
        {
            for (int i = 0; i < theMap.GetLength(0); i++)
            {
                for (int j = 0; j < theMap.GetLength(1); j++)
                {
                    theMap[i, j] = new EmptyTile(i, j,'.');
                }
            }

            for (int i = 0; i < theMap.GetLength(0); i++)
            {
                for (int j = 0; j < theMap.GetLength(1); j++)
                {
                   if (i == 0 || j == 0|| i == mapWide - 1 || j == mapLong - 1)
                    {
                        theMap[i, j] = new Obstacle(i,j,'X');
                    }
                }
            }

        }
    }
}
