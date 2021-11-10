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
        private int ItemNumber;
        private Item item;
        
        //Accessors cause yeah, real helpful
        public Hero Player { set{ player = value; } get{ return player; } } 
        public Goblin Gobolobolin { set { Gob = value; } get { return Gob; } }
        public int NumEnemies { set{ enemynumber = value; } get{ return enemynumber; } }
        public int Width { set { mapWide = value; } get { return mapWide; } }
        public int Height { set { mapLong = value; } get { return mapLong; } }
        public Tile[,] Tilemappy { set { theMap = value; } get { return theMap; } } 
        public Item[] Iteems { set{ Itemythings = value; } get{ return Itemythings; } }

        
        //Arry things
        private Tile[,] theMap;
        private Enemy[] arrayofenemies;
        private Item[] Itemythings;
        
        //Player Variable
        private Hero player;
        private Goblin Gob;
               
        //Random number generator
        private Random RanDumb = new Random();

        public Map(int MinHeight, int MinWidth, int MaxHeight, int MaxWidth, int NumEnemies, int NumGold)
        {   
            Random RanDum = new Random();
            
            mapLong = RanDum.Next(MinHeight,MaxHeight + 1);
            mapWide = RanDum.Next(MinWidth, MaxWidth + 1);

            theMap = new Tile[mapWide,mapLong];

            arrayofenemies = new Enemy[enemynumber];
            Itemythings = new Item[NumGold];

            FillMap();

            Player = (Hero)create(Tile.TileType.Hero);
            theMap[player.getx, player.gety] = player;

            for (int i = 0; i < arrayofenemies.Length; i++)
            {
                arrayofenemies[i] = (Enemy)create(Tile.TileType.Enemy);
                theMap[arrayofenemies[i].getx, arrayofenemies[i].gety] = arrayofenemies[i];
            }
            
            for (int i = 0; i < Itemythings.Length; i++)
            {
                Itemythings[i] = (Gold)create(Tile.TileType.Gold);
                theMap[Itemythings[i].getx, Itemythings[i].gety] = Itemythings[i];
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
            for (int j = 0; j < Itemythings.Length; j++)
            {
                theMap[Itemythings[j].getx,Itemythings[j].gety] = Itemythings[j];
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
            int EnemType;

            

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
                        EnemType = RanDum.Next(0, 2);
                    } while (IsTileOpen(RNGX, RNGY));

                    if (EnemType == 0)
                    {
                        return new Goblin(RNGX, RNGY);
                    }
                    else
                    {
                        return new Mage(RNGX, RNGY);
                    }
                case Tile.TileType.Gold:
                    do
                    {
                        RNGX = RanDum.Next(1, theMap.GetLength(0));
                        RNGY = RanDum.Next(1, theMap.GetLength(1));
                    } while (IsTileOpen(RNGX, RNGY));

                    return new Gold(RNGX,RNGY);
/*
                case Tile.TileType.Item:
                    do
                    {
                        RNGX = RanDum.Next(1, theMap.GetLength(0));
                        RNGY = RanDum.Next(1, theMap.GetLength(1));
                    } while (IsTileOpen(RNGX, RNGY));
                    return new Item(RNGX, RNGY);
*/
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
                /*enemy.Vision[0] = theMap[enemy.getx - 1, enemy.gety];
                enemy.Vision[1] = theMap[enemy.getx + 1, enemy.gety];
                enemy.Vision[2] = theMap[enemy.getx, enemy.gety - 1];
                enemy.Vision[3] = theMap[enemy.getx, enemy.gety + 1];*/
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

        public Item GetItemAtPosition(int x, int y)
        {
            for (int i = 0; i < theMap.GetLength(0); i++)
            {
                for (int j = 0; j < theMap.GetLength(1); j++)
                {
                    if (Itemythings[j] == item)
                    {
                        item = item;
                    }
                    else 
                    {
                        item = null;
                    }
                }
            }

            return item;
        }
    }
}
