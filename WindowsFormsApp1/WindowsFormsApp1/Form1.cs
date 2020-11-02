using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class window : Form
    {   
        int livesLeft = 10;
        int livesLost = 0;
        int winScore;
        char c1, c2, c3, c4, c5, c6;
        char[] attempt;
        char[] secretWordLetters;
        

        private void secretWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if(secretWord.Text.Length > 6)
            {
                MessageBox.Show("Please choose a 6 letter word.");
                return;
            }
            secretWord.Text = secretWord.Text.ToLower();
            secretWordLetters = secretWord.Text.ToCharArray();
            foreach (char letter in secretWordLetters)
            {
                if (letter < 'a' || letter > 'z')
                {
                    MessageBox.Show("Invalid Characters. Please insert only letters.");
                    return;
                }
            }
            textAttempt.ReadOnly = false;
            secretWord.Visible = false;
            btStart.Visible = false;
            c1 = secretWord.Text[0]; c2 = secretWord.Text[1]; c3 = secretWord.Text[2]; c4 = secretWord.Text[3]; c5 = secretWord.Text[4]; c6 = secretWord.Text[5];
            MessageBox.Show("Start! The word has 6 letters");
        }

        private void secretLetter1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTry_Click(object sender, EventArgs e)
        {
            {
                attempt = textAttempt.Text.ToCharArray();             
                if (attempt[0] < 'a' || attempt[0] > 'z' || attempt.Length != 1)
                {
                    MessageBox.Show("Invalid Character. Please insert a lower case letter.");
                    return;
                }
                if (ttbAttempt.Text.Contains(textAttempt.Text.ToLower()))
                {
                    MessageBox.Show("You've already tried that letter!");
                    return;
                }
                else
                {
                    ttbAttempt.Text += textAttempt.Text + " ";
                if (secretWord.Text.Contains(textAttempt.Text))
                {
                    if (textAttempt.Text == c1.ToString())
                    {
                        secretLetter1.Text = textAttempt.Text;
                        winScore++;
                    }
                    if (textAttempt.Text == c2.ToString())
                    {
                        secretLetter2.Text = textAttempt.Text;
                        winScore++;
                    }
                    if (textAttempt.Text == c3.ToString())
                    {
                        secretLetter3.Text = textAttempt.Text;
                        winScore++;
                    }
                    if (textAttempt.Text == c4.ToString())
                    {
                        secretLetter4.Text = textAttempt.Text;
                        winScore++;
                    }
                    if (textAttempt.Text == c5.ToString())
                    {
                        secretLetter5.Text = textAttempt.Text;
                        winScore++;
                    }
                    if (textAttempt.Text == c6.ToString())
                    {
                        secretLetter6.Text = textAttempt.Text;
                        winScore++;
                    }
                        if (winScore == 6)
                        {
                            MessageBox.Show("You have won! Thanks for playing!");
                            Resetter();
                        }
                }
                else 
                {
                    livesLeft--;
                    livesLost++;
                }
                    
                    lbLives.Text = "Lives left: " + livesLeft.ToString();
                    
                    textAttempt.Text = "";
                    if (livesLost == 1)
                    {
                        rope.Image = WindowsFormsApp1.Properties.Resources.pendu1;
                    }
                    if (livesLost == 2)
                    {
                        rope.Image = WindowsFormsApp1.Properties.Resources.pendu2;
                    }
                    if (livesLost == 3)
                    {
                        rope.Image = WindowsFormsApp1.Properties.Resources.pendu3;
                    }
                    if (livesLost == 4)
                    {
                        rope.Image = WindowsFormsApp1.Properties.Resources.pendu4;
                    }
                    if (livesLost == 5)
                    {
                        rope.Image = WindowsFormsApp1.Properties.Resources.pendu5;
                    }
                    if (livesLost == 6)
                    {
                        rope.Image = WindowsFormsApp1.Properties.Resources.pendu6;
                    }
                    if (livesLost == 7)
                    {
                        rope.Image = WindowsFormsApp1.Properties.Resources.pendu7;
                    }
                    if (livesLost == 8)
                    {
                        rope.Image = WindowsFormsApp1.Properties.Resources.pendu8;
                    }
                    if (livesLost == 9)
                    {
                        rope.Image = WindowsFormsApp1.Properties.Resources.pendu9;
                    }
                    if (livesLost == 10)
                    {
                        rope.Image = WindowsFormsApp1.Properties.Resources.pendu10;
                        MessageBox.Show("Game Over! The word was " + secretWord.Text);
                        Resetter();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Resetter();

        }

        private void Resetter()
        {
            secretWord.Text = "Insert the secret word(6 letters)";           
            textAttempt.ReadOnly = true;
            rope.Image = rope.Image = WindowsFormsApp1.Properties.Resources.pendu0;
            secretWord.Visible = true;
            btStart.Visible = true;
            ttbAttempt.Text = "";
            secretLetter1.Text = "";
            secretLetter2.Text = "";
            secretLetter3.Text = "";
            secretLetter4.Text = "";
            secretLetter5.Text = "";
            secretLetter6.Text = "";
            winScore = 0;
        }
        public window()
        {
            InitializeComponent();
        }


    }
        
}
