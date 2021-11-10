using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hein_Kroese_GADE6112_POE
{
    class GameEngine
    {
        //Charactermachurs
        private static char HeroBoi = 'H';
        private static char EmptySpace = '.';
        private static char Obsticle = 'X';
        private static char GoblinyBoi = 'G';
        private static char Magewage = 'M';
        private static char MONEY = 'I';
        private string MapString = String.Empty;

        
        private Map MappyBoi;

        public Map MappyGurl { set { MappyBoi = value; } get { return MappyBoi; } }


        public GameEngine()
        {
            MappyBoi = new Map(10, 14, 10, 14, 4, 3);
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
                    
                    if (MappyBoi.Tilemappy[i,j].GetType() == typeof(Gold))
                    {
                        MapChar[i, j] = MONEY;
                    }

                    if (MappyBoi.Tilemappy[i, j].GetType() == typeof(Hero))
                    {
                        MapChar[i, j] = HeroBoi;
                    }

                    if (MappyBoi.Tilemappy[i, j].GetType() == typeof(EmptyTile))
                    {
                        MapChar[i, j] = EmptySpace;
                    }
                    
                    if (MappyBoi.Tilemappy[i, j].GetType() == typeof(Goblin))
                    {
                        MapChar[i, j] = GoblinyBoi;
                    }

                    if (MappyBoi.Tilemappy[i, j].GetType() == typeof(Mage))
                    {
                        MapChar[i, j] = Magewage;
                    }

                    MapStringy += MapChar[i, j];
                }
                MapStringy += "\n";
            }
            return $"{MapStringy}";
            

        }

        public static void SaveGame(string Map)
        {
            var dir = Directory.GetCurrentDirectory();
            var file = Path.Combine(dir, "Save.dat");

            try
            {
                FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write);
                               
                if (fs.CanWrite)
                {
                    byte[] buffer = Encoding.ASCII.GetBytes(Map);
                    fs.Write(buffer, 0, buffer.Length);
                }

                fs.Flush();
                fs.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string LoadGame()
        {
            var dir = Directory.GetCurrentDirectory();
            var file = Path.Combine(dir, "Save.dat");
            string Text = String.Empty;

            try
            {
                FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
                byte[] buffer = new byte[1024];
                int bytesread = fs.Read(buffer, 0, buffer.Length);

                Text = Encoding.ASCII.GetString(buffer, 0, bytesread);

                fs.Flush();
                fs.Close();
            }
            catch (Exception ex)
            {
                throw;
            }

            return Text;
            
        }

    }
}

