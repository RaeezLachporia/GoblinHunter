using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoblinHunter
{
    public partial class goblinHunterFRM : Form
    {
        private GameEngine game;
        
        public goblinHunterFRM()
        {
            InitializeComponent();
            game = new GameEngine(10, 10, " ", Tile.TileType.Empty, 10, 10, 10, 10, 10, 10,10,10);
            
        }

        private void downButtonPress_Click(object sender, EventArgs e)
        {

        }

        private void mapLBL_Click(object sender, EventArgs e)
        {
            
        }
        public void Draw()
        {
            
        }
    }
}
