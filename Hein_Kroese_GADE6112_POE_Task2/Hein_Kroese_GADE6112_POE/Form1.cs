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
           lblMap.Text = VideoJames.ToString();
           lblHeroStats.Text = VideoJames.Map.Player.ToString();
         //lblEnemy.Text = VideoJames.Map.Gobolobolin.ToString();
        }

        private void lblMap_Click(object sender, EventArgs e)
        {

        }

        private void lblHeroStats_Click(object sender, EventArgs e)
        {
          
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
            VideoJames.MovePlayer(MovementEnum.Up);
            VideoJames.MoveEnemies(MovementEnum.Down);
            VideoJames.Map.updateMap();
            lblMap.Text = VideoJames.ToString();
            lblHeroStats.Text = VideoJames.Map.Player.ToString();
            
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            VideoJames.MovePlayer(MovementEnum.Down);
            VideoJames.MoveEnemies(MovementEnum.Up);
            VideoJames.Map.updateMap();
            lblMap.Text = VideoJames.ToString();
            lblHeroStats.Text = VideoJames.Map.Player.ToString();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            VideoJames.MovePlayer(MovementEnum.Right);
            VideoJames.MoveEnemies(MovementEnum.Left);
            VideoJames.Map.updateMap();
            lblMap.Text = VideoJames.ToString();
            lblHeroStats.Text = VideoJames.Map.Player.ToString();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            VideoJames.MovePlayer(MovementEnum.Left);
            VideoJames.MoveEnemies(MovementEnum.Right);
            VideoJames.Map.updateMap();
            lblMap.Text = VideoJames.ToString();
            lblHeroStats.Text = VideoJames.Map.Player.ToString();
        }
    }
}
