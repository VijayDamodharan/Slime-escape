using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_game_2
{
    public partial class End_Screen : Form
    {
        int score;
        int level;
        bool lost;
        
        public End_Screen(Form1 form)
        {
            InitializeComponent();

            score = form.score;
            lost = form.health == 0;
            level = form.level;
            this.lbEndText.AutoSize = true;

            if (lost)
            {
                this.Text = "You lost";
                lbEndText.Text = Wrap($"Sorry, you lost! You reached level {level} and collected {score} flames. Would you like to try again?");
                
            }
            else
            {
                this.Text = "You won!";
                lbEndText.Text = Wrap($"Great, you won! You reached level {level} and collected {score} flames. Would you like to play again?");

            }
        }

        private string Wrap(string text)
        {
            List<string> txt = text.Split(' ').ToList();
            
            int maxLength = 8 * (this.ClientSize.Width / (int)lbEndText.Font.Size) / 9; // no of characters that can fit within 6/7 of central screen
            string wrappedText = "";
            int curLength = 0;

            foreach (String word in txt)
            {
                curLength += word.Length;
                if (curLength >= maxLength)
                {
                    wrappedText += $"\n{word} ";
                    curLength = word.Length;
                    continue;
                }
                wrappedText += $"{word} ";
            }

            return wrappedText;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
