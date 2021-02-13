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
        Player _player = new Player();
        public AdventureGame()
        {
            InitializeComponent();
            _player.CurrentHP = 10;
            _player.MaxHP = 10;
            _player.CurrentGold = 20;
            _player.XP = 0;
            _player.Lvl = 1;

            labelGold.Text = _player.CurrentGold.ToString();
            labelHitPoints.Text = _player.CurrentHP.ToString();
            labelLVL.Text = _player.Lvl.ToString();
            labelXP.Text = _player.XP.ToString();
        }

        
    }
}
