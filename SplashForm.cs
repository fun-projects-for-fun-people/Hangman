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
    public partial class SplashForm : Form
    {
        public static int difficultyLevel = -1;

        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to Quit?",
                 "Quit Hangman?",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Information) == DialogResult.Yes)
            { Environment.Exit(1); }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbxDifficulty.SelectedIndex != -1)
            {
                difficultyLevel = cbxDifficulty.SelectedIndex;
                MainGame game = new Hangman.MainGame();
                game.Show();
                this.Hide();
            }
            else
            {
                cbxDifficulty.Focus();
            }
        }
    }
}
