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

        private void frmGame_Load(object sender, EventArgs e)
        {   
            //Shows hero stats
            Hero herostats = new Hero(2,2,'H',10,10,2,3);
            lblHeroStats.Text = herostats.ToString();
            //Shows enemy stats
            Goblin enemystats = new Goblin(2, 2, 'H', 10, 10, 2);
            lblEnemy.Text = enemystats.ToString();
            //Show map
            Map map = new Map(1,1,1,1,1);
            lblMap.Text = map.ToString();
        }
    }
}
