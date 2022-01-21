using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class MainGame : Form
    {
        private int difficultyLvl = -1;
        public MainGame()
        {
            InitializeComponent();
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            difficultyLvl = SplashForm.difficultyLevel;

            switch (difficultyLvl)
            {
                case 0:
                    lblDifficulty.Text += "Easy";
                    break;

                case 1:
                    lblDifficulty.Text += "Moderate";
                    break;

                case 2:
                    lblDifficulty.Text += "Hard";
                    break;

                case 3:
                    lblDifficulty.Text += "Extreme";
                    break;

            }
        }

        private void MainGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure want to Quit?",
                               "Quit Hangman?",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                { Environment.Exit(1); }
                else
                { e.Cancel = true; }
            }
        }

    }
}
