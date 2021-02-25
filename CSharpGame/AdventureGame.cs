using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace CSharpGame
{
    public partial class AdventureGame : Form
    {
        Player _player = new Player(20, 0, 1, 10, 10);
        public AdventureGame()
        {
            InitializeComponent();

            labelGold.Text = _player.CurrentGold.ToString();
            labelHitPoints.Text = _player.CurrentHP.ToString();
            labelLVL.Text = _player.Lvl.ToString();
            labelXP.Text = _player.XP.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonNorth_Click(object sender, EventArgs e)
        {

        }

        private void buttonWest_Click(object sender, EventArgs e)
        {

        }

        private void buttonSouth_Click(object sender, EventArgs e)
        {

        }

        private void buttonEast_Click(object sender, EventArgs e)
        {

        }

        private void buttonUseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void buttonUsePotion_Click(object sender, EventArgs e)
        {

        }
    }
}
