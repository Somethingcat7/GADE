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
        public Tile[,] theMap;
        public Enemy[] arrayofenemies;
        public Item[] Itemythings;
        
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

            Player = (Hero)create(TileType.Hero);
            theMap[player.getx, player.gety] = player;

            for (int i = 0; i < arrayofenemies.Length; i++)
            {
                arrayofenemies[i] = (Enemy)create(TileType.Enemy);
                theMap[arrayofenemies[i].getx, arrayofenemies[i].gety] = arrayofenemies[i];
            }
            
            for (int i = 0; i < Itemythings.Length; i++)
            {
                Itemythings[i] = (Gold)create(TileType.Gold);
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
           
            Addgold();
           
            for (int j = 0; j < Itemythings.Length; j++)
            {
                theMap[Itemythings[j].getx,Itemythings[j].gety] = Itemythings[j];
            }

            UpdateVision();
        }
        
        public Tile[,] Mappymap { set { theMap = value; } get { return theMap; } }
       
        //Create the tiles, it's litteraly in the name
        private Tile create(TileType MakingOfTile)
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
                case TileType.Hero:
                    do
                    {
                        RNGX = RanDum.Next(1, theMap.GetLength(0));
                        RNGY = RanDum.Next(1, theMap.GetLength(1));
                    } while (IsTileOpen(RNGX,RNGY));

                    return new Hero(RNGX, RNGY);

                case TileType.Enemy:
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
                case TileType.Gold:
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
            foreach (Enemy enemy in arrayofenemies)
            {
                enemy.Vision[0] = theMap[enemy.getx - 1, enemy.gety];
                enemy.Vision[1] = theMap[enemy.getx + 1, enemy.gety];
                enemy.Vision[2] = theMap[enemy.getx, enemy.gety - 1];
                enemy.Vision[3] = theMap[enemy.getx, enemy.gety + 1];
            }

            Player.Vision[0] = theMap[Player.getx, Player.gety - 1];
            Player.Vision[1] = theMap[Player.getx, Player.gety + 1];
            Player.Vision[2] = theMap[Player.getx + 1, Player.gety];
            Player.Vision[3] = theMap[Player.getx - 1, Player.gety];

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

        private void Addgold()
        {
            for (int i = 0; i < Itemythings.Length; i++)
            {
                if (Mappymap[Player.getx, Player.gety] == Mappymap[Itemythings[i].getx, Itemythings[i].gety])
                {
                    Player.Pickup(GetItemAtPosition(Player.getx, Player.gety));
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
        public string redraw()
        {
            string output = "";
            for (int y = 0; y < theMap.GetLength(1); y++)
            {
                for (int x = 0; x < theMap.GetLength(0); x++)
                {
                    output += theMap[x, y].getsymbol;
                }
                output += '\n';
            }
            return output;
        }
    }
}
