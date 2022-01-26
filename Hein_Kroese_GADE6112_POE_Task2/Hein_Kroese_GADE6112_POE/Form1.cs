using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hein_Kroese_GADE6112_POE
{
    public partial class frmGame : Form
    {
        
        public frmGame()
        {
            InitializeComponent();
            
        }

        GameEngine VideoJames = new GameEngine();
        private void frmGame_Load(object sender, EventArgs e)
        {
            DrawMap();
         //lblEnemy.Text = VideoJames.Map.Gobolobolin.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GameEngine.SaveGame(VideoJames.ToString());
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lblMap.Text = GameEngine.LoadGame();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            VideoJames.Map.Player.Move(VideoJames.Map.Player.ReturnMove(Character.MovementEnum.Up));
            VideoJames.Map.MoveBaddies();
            VideoJames.Map.updateMap();
            lblMap.Text = VideoJames.ToString();
            lblHeroStats.Text = VideoJames.Map.Player.ToString();
            DrawMap();

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            VideoJames.Map.Player.Move(VideoJames.Map.Player.ReturnMove(Character.MovementEnum.Down));
            VideoJames.Map.MoveBaddies();
            VideoJames.Map.updateMap();
            lblMap.Text = VideoJames.ToString();
            lblHeroStats.Text = VideoJames.Map.Player.ToString();
            DrawMap();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            VideoJames.Map.Player.Move(VideoJames.Map.Player.ReturnMove(Character.MovementEnum.Right));
            VideoJames.Map.MoveBaddies();
            VideoJames.Map.updateMap();
            lblMap.Text = VideoJames.ToString();
            lblHeroStats.Text = VideoJames.Map.Player.ToString();
            DrawMap();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            VideoJames.Map.Player.Move(VideoJames.Map.Player.ReturnMove(Character.MovementEnum.Left));
            VideoJames.Map.MoveBaddies(); 
            VideoJames.Map.updateMap();
            lblMap.Text = VideoJames.ToString();
            lblHeroStats.Text = VideoJames.Map.Player.ToString();
            DrawMap();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < VideoJames.Map.arrayofenemies.Length; i++)
            {
                // attack first attackable enemy in enemy array
                if (VideoJames.Map.Player.CheckRange(VideoJames.Map.arrayofenemies[i]))
                {
                    VideoJames.Map.Player.Attack(VideoJames.Map.arrayofenemies[i]);

                    VideoJames.Map.MoveBaddies();

                    lblAttackNotif.Visible = true;
                    lblAttackNotif.Text = $"Attack was succsesful! \n {VideoJames.Map.arrayofenemies[i].GetType().Name} took {VideoJames.Map.Player.getDamage} damage!";
                    lblAttackNotif.Text += $"\n{VideoJames.Map.arrayofenemies[i].GetType().Name} is now on {VideoJames.Map.arrayofenemies[i].getMaxHealth} HP!";

                    if (VideoJames.Map.arrayofenemies[i].isDead())
                    {
                        lblAttackNotif.Text = "An enemy has been slain!";
                    }

                    break;  //stops at the first attackable enemy
                }

                else
                {
                    lblAttackNotif.Text = "No enemy in range ;-;";
                }

                VideoJames.Map.updateMap();
                DrawMap();
            }
        }

        private void DrawMap()
        {
            lblMap.Text = VideoJames.ToString();

            lblHeroStats.Text = VideoJames.Map.Player.ToString();

            cmbEnemies.DataSource = VideoJames.Map.arrayofenemies;
            cmbItems.DataSource = VideoJames.Map.Itemythings;
        }

        private void lblAttackNotif_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
