using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Hangman_Game
{
    public partial class Form1 : Form
    {
        private Bitmap[] hangImages = {Hangman_Game_v2.Properties.Resources.hang1, Hangman_Game_v2.Properties.Resources.hang2,
                                       Hangman_Game_v2.Properties.Resources.hang3, Hangman_Game_v2.Properties.Resources.hang4,
                                       Hangman_Game_v2.Properties.Resources.hang5, Hangman_Game_v2.Properties.Resources.hang6,
                                       Hangman_Game_v2.Properties.Resources.hang7};

        private int guesses = 0;
        private int guessIndex;
        private string current = "";
        private string copyCurrent = "";
        private int guessesLeft = 7;
        private string[] words;
        private string[] hints;
        private SoundPlayer Win, Lose, Correct, Wrong;


        public Form1()
        {
            InitializeComponent();
            Win = new SoundPlayer("Tada-sound.wav");
            Lose = new SoundPlayer("game-lose.wav");
            Correct = new SoundPlayer("Correct.wav");
            Wrong = new SoundPlayer("Wrong.wav");

            answerTitle.Hide();
        }
        private void loadwords()
        {
            char[] delimiterChars = { ',' };
            string[] readText = File.ReadAllLines("Words.txt");//Reads all words in .txt file
            int index = 0;

            words = new string[readText.Length]; 
            hints = new string[readText.Length];
            foreach(string s in readText) 
            {
                string[] line = s.Split(delimiterChars); //Seperates each word in a sentence according to delimiter
                words[index] = line[1];//Load middle item into words array
                hints[index] = line[2];//load last item into hints array
                index++;
            }

        }
        private void setupWordChoice()
        {
            guesses = 0;
            
            guessesLeftLabel.Text = guessesLeft.ToString();
            hangImage.Image = hangImages[guesses];
            guessIndex = (new Random()).Next(words.Length); //Creates new random class, use .Next to give it length of word which would generate random number
            current = words[guessIndex];

            copyCurrent = "";

            for(int index = 0; index < current.Length; index++)//runs for however many characters in current
            {
                copyCurrent += "_"; //copyCurrent = copyCurrent + "_";
            }
            displayCopy();//makes copy of guess in length and display to wordLabel.Text
        }

        private void displayCopy()
        {
            wordLabel.Text = "";
            for (int index = 0; index < current.Length; index++)//runs for however many characters in current
            {
                wordLabel.Text += copyCurrent.Substring(index, 1);// Copies each character one at a time 
                wordLabel.Text += " "; //wordLabel.Text = wordLabel.Text + " ";
            }
        }
        private void guessTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(guessTextBox.Text, "^[a-zA-Z ]?$")) //Validates each keystroke. If input is not A-Z or left blank, display message and clear textbox
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                guessTextBox.Text = "";
            }
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            string strTemp;
            string letters = guessTextBox.Text.ToUpper();

            try
            {
                strTemp = guessTextBox.Text;
                char guessChar = letters.ElementAt(0);
            }
            catch
            {
                MessageBox.Show("Please enter a letter!");
                return;
            }
            if (current.Contains(letters)) //Check if letter guessed is correct or not
            {
                char[] temp = copyCurrent.ToCharArray();
                char[] find = current.ToCharArray();
                char guessChar = letters.ElementAt(0);
                for (int index = 0; index < find.Length; index++)
                {
                    if (find[index] == guessChar)
                    {
                        temp[index] = guessChar;
                    }
                }
                copyCurrent = new string(temp);
                displayCopy();
                Correct.Play();
              
            }
            else
            {
                guesses++;
                guessesLeft--;
                guessesLeftLabel.Text = guessesLeft.ToString();
                Wrong.Play();
                
            }
            if(guesses < 7)
            {
                hangImage.Image = hangImages[guesses];//Change image with each wrong guess
            }
            else
            {
             
                Lose.Play();
                outcomeLabel.Show();
                outcomeLabel.Text = "You lose!\nPress New Game to play again!"; 
                outcomeLabel.ForeColor = Color.Red;
                guessButton.Enabled = false;
                answerTitle.Show(); 
                answerLabel.Text = words[guessIndex].ToString();
            }
            if (copyCurrent.Equals(current))
            {
                Win.Play();
                outcomeLabel.Show();
                guessButton.Enabled = false;
                outcomeLabel.Text = "You win!\nPress New Game to play again!";
                outcomeLabel.ForeColor = Color.Green;
            }
            
            StreamWriter rt = new StreamWriter(@"C:\Users\User\Desktop\Projects\Hangman\lettersGuessed.txt");
            rt.WriteLine(letters);
            rt.Close();

            StreamReader rv = new StreamReader(@"C:\Users\User\Desktop\Projects\\Hangman\lettersGuessed.txt");
            string s = rv.ReadLine();
            lettersGuessedBox.Items.Add(s);
            rv.Close();
          
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadwords();
            setupWordChoice();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            guessesLeft = 7;

            setupWordChoice();
            lettersGuessedBox.Items.Clear();
            guessTextBox.Clear();
            hintLabel.Text = "";
            answerLabel.Text = "";
            answerTitle.Hide();
            outcomeLabel.Hide();    
            guessesLeftLabel.Text = guessesLeft.ToString();
            guessButton.Enabled = true;
        }

        private void hintButton_Click(object sender, EventArgs e)
        {
            hintLabel.Text = hints[guessIndex];
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
