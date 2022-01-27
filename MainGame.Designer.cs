namespace Hangman
{
    partial class MainGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

        //https://www.phrases.com/phrases_api.php

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblQuote = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.rtbQuote = new System.Windows.Forms.RichTextBox();
            this.cbxLetters = new System.Windows.Forms.ComboBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.clbGuesses = new System.Windows.Forms.CheckedListBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(17, 21);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(106, 25);
            this.lblDifficulty.TabIndex = 0;
            this.lblDifficulty.Text = "Difficulty: ";
            // 
            // lblQuote
            // 
            this.lblQuote.AutoSize = true;
            this.lblQuote.Location = new System.Drawing.Point(17, 490);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(82, 25);
            this.lblQuote.TabIndex = 1;
            this.lblQuote.Text = "Quote: ";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(12, 793);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(87, 25);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author: ";
            // 
            // rtbQuote
            // 
            this.rtbQuote.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rtbQuote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbQuote.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbQuote.Location = new System.Drawing.Point(17, 518);
            this.rtbQuote.Name = "rtbQuote";
            this.rtbQuote.Size = new System.Drawing.Size(1044, 263);
            this.rtbQuote.TabIndex = 3;
            this.rtbQuote.Text = "";
            // 
            // cbxLetters
            // 
            this.cbxLetters.FormattingEnabled = true;
            this.cbxLetters.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cbxLetters.Location = new System.Drawing.Point(940, 75);
            this.cbxLetters.Name = "cbxLetters";
            this.cbxLetters.Size = new System.Drawing.Size(121, 33);
            this.cbxLetters.TabIndex = 4;
            this.cbxLetters.SelectedIndexChanged += new System.EventHandler(this.cbxLetters_SelectedIndexChanged);
            // 
            // btnGuess
            // 
            this.btnGuess.Enabled = false;
            this.btnGuess.Location = new System.Drawing.Point(940, 21);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(121, 48);
            this.btnGuess.TabIndex = 5;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // clbGuesses
            // 
            this.clbGuesses.Enabled = false;
            this.clbGuesses.FormattingEnabled = true;
            this.clbGuesses.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.clbGuesses.Location = new System.Drawing.Point(1087, 21);
            this.clbGuesses.Name = "clbGuesses";
            this.clbGuesses.Size = new System.Drawing.Size(66, 760);
            this.clbGuesses.TabIndex = 6;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(17, 59);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(86, 25);
            this.lblHealth.TabIndex = 7;
            this.lblHealth.Text = "Health: ";
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 832);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.clbGuesses);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.cbxLetters);
            this.Controls.Add(this.rtbQuote);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.lblDifficulty);
            this.Name = "MainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainGame_FormClosing);
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.RichTextBox rtbQuote;
        private System.Windows.Forms.ComboBox cbxLetters;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.CheckedListBox clbGuesses;
        private System.Windows.Forms.Label lblHealth;
    }
}