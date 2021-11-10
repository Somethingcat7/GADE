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
            lblHeroStats.Text = VideoJames.ToString();
           // lblHeroStats.Text = VideoJames.MappyGurl.player.ToString();
        }

        private void lblMap_Click(object sender, EventArgs e)
        {

        }
    }
}
