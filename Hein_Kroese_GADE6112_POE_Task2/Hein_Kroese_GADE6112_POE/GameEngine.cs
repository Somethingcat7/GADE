﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hein_Kroese_GADE6112_POE
{
    class GameEngine
    {
        private string MapString = String.Empty;

        
        private Map map;
        public Map Map { set { map = value; } get { return map; } }


        public GameEngine()
        {
            map = new Map(10, 14, 10, 14, 6, 3);
        }
        //Player doing a movement
        public void MovePlayer(MovementEnum motion)
        {
            switch (motion)
            {
                //move up
                case MovementEnum.Up:
                    map.Player.Move(map.Player.ReturnMove(MovementEnum.Up));
                    break;

                //move down
                case MovementEnum.Down:
                    map.Player.Move(map.Player.ReturnMove(MovementEnum.Down));
                    break;

                //move left
                case MovementEnum.Left:
                    map.Player.Move(map.Player.ReturnMove(MovementEnum.Left));
                    break;

                //move right
                case MovementEnum.Right:
                    map.Player.Move(map.Player.ReturnMove(MovementEnum.Right));
                    break;
            }
        }
        //Enemies doing a movement
        public void MoveEnemies(MovementEnum movement)
        {
            for (int i = 0; i < map.arrayofenemies.Length; i++)
            {
                map.arrayofenemies[i].Move(map.arrayofenemies[i].ReturnMove(movement));
            }
            EnemyAttack();
        }
        //Enemies doing an attack
        public void EnemyAttack()
        {
            for (int i = 0; i < map.arrayofenemies.Length; i++)
            {

                switch (map.arrayofenemies[i].getsymbol)
                {
                    case 'G':
                        foreach (Tile T in map.arrayofenemies[i].Vision)
                        {
                            if (T.getx == map.Player.getx && (T.gety == map.Player.gety))
                            {
                                map.arrayofenemies[i].Attack(map.Player);
                            }
                        }
                        break;

                    case 'M':
                        map.arrayofenemies[i].Attack(map.Player);
                        break;
                }
            }

        }
        //It does all of the things :D
        public override string ToString()
        {
            return map.redraw();         
        }

        //Redraw the map
       

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

