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

        //http://quotes.stormconsultancy.co.uk/api   A hand picked selection of quotes from the field of computer science.

        private int difficultyLvl = -1;
        private int health = 0;
        private string quoteString = "";
        private string hiddenQuote = "";
        public MainGame()
        {
            InitializeComponent();
            ApiClass.InitializeClient();
        }

        private async Task GetNewPhrase()
        {
            var quote = await GetPhrase.LoadPhrase();
            string trueQuote = quote.quote;
            string hiddenQuote = HideQuote(quote.quote);
            rtbQuote.Text = hiddenQuote;
            lblAuthor.Text += quote.author;
        }

        private string HideQuote(string quote)
        {
            StringBuilder full = new StringBuilder();
            StringBuilder hidden = new StringBuilder();

            foreach (char c in quote)
            {
                if (c.ToString() == " " || c.ToString().ToUpper() != c.ToString().ToLower())
                {
                    full.Append(c);
                }
            }

            quoteString = full.ToString();

            foreach (char c in quoteString)
            {
                if (c.ToString() != " ")
                {
                    hidden.Append('-');
                }
                else
                {
                    hidden.Append(c);
                }
            }
            hiddenQuote = hidden.ToString();
            lblHealth.Text = "Health: " + health.ToString();
            return hiddenQuote;
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            difficultyLvl = SplashForm.difficultyLevel;

            switch (difficultyLvl)
            {
                case 0:
                    lblDifficulty.Text += "Easy";
                    health = 9;
                    break;

                case 1:
                    lblDifficulty.Text += "Moderate";
                    health = 6;
                    break;

                case 2:
                    lblDifficulty.Text += "Hard";
                    health = 3;
                    break;

                case 3:
                    lblDifficulty.Text += "Extreme";
                    health = 1;
                    break;

            }

            GetNewPhrase();

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

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (cbxLetters.SelectedIndex != -1)
            {
                if (quoteString.ToUpper().Contains(cbxLetters.SelectedItem.ToString().ToUpper()))
                {
                    RevealLetter(Convert.ToChar(cbxLetters.SelectedItem));
                }
                else
                {
                    health = health - 1;
                    if (health <= 0)
                    {
                        lblHealth.Text = "Health: DEAD";
                        MessageBox.Show("You Lose!!!");
                    }
                    else
                    {
                        lblHealth.Text = "Health: " + health.ToString();
                    }
                }

                UpdateGuessList(cbxLetters.SelectedIndex);
                cbxLetters.SelectedIndex = -1;
            }
        }

        private void UpdateGuessList(int selected)
        {
            clbGuesses.SetItemChecked(selected, true);
        }

        private void RevealLetter(char letter)
        {
            char[] arr = hiddenQuote.ToCharArray();
            string newHidden;

            for (int i = 0; i < hiddenQuote.Length; i++)
            {
                if (quoteString.ToCharArray()[i].ToString().ToUpper() == letter.ToString().ToUpper())
                {
                    arr[i] = quoteString.ToCharArray()[i];
                }
            }
            newHidden = new string(arr);
            hiddenQuote = newHidden;

            rtbQuote.Text = hiddenQuote;
            if (hiddenQuote == quoteString)
            {
                MessageBox.Show("You Win!!!");
            }
        }

        private void cbxLetters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLetters.SelectedIndex != -1 && clbGuesses.GetItemCheckState(cbxLetters.SelectedIndex) != CheckState.Checked)
            {
                btnGuess.Enabled = true;
            }
            else
            {
                btnGuess.Enabled = false;
                cbxLetters.SelectedIndex = -1;
            }                  
        }

    }
}
