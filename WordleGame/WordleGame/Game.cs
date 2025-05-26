using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordleGame.EF;

namespace WordleGame
{
    public partial class Game : Form
    {

        private string currentWord;
        private int attempt = 0;
        private const int maxAttempts = 6;
        private void LoadRandomWord()
        {
            using (var db = new WordleModel())
            {
                int wordCount = db.Words.Count();
                if (wordCount == 0)
                {
                    MessageBox.Show("No words available in the database.");
                    btnSubmit.Enabled = false;
                    return;
                }

                
                var random = new Random();
                int skip = random.Next(0, wordCount);

                currentWord = db.Words
                                .OrderBy(w => Guid.NewGuid())
                                .Select(w => w.Words)
                                .Skip(skip)
                                .FirstOrDefault();

                if (string.IsNullOrEmpty(currentWord))
                {
                    MessageBox.Show("Failed to load a word.");
                    btnSubmit.Enabled = false;
                }
            }
        }
        private void InitializeGrid()
        {
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.ColumnCount = 5;

            tableLayoutPanel1.Controls.Clear();

            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    var label = new Label
                    {
                        Dock = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Segoe UI", 18, FontStyle.Bold),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.White,
                        Name = $"label_{row}_{col}"
                    };
                    tableLayoutPanel1.Controls.Add(label, col, row);
                }
            }
        }
        public Game()
        {
            InitializeComponent();
            LoadRandomWord();
            InitializeGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            Game game = new Game();
            this.Hide();
            gameForm.Show();
            game.FormClosed += (s, args) => this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Stats stats = new Stats();
            Game game = new Game();
            this.Hide();
            stats.Show();
            game.FormClosed += (s, args) => this.Close();
        }

        private Label GetLabelFromGrid(int row, int col)
        {
            return (Label)tableLayoutPanel1.GetControlFromPosition(col, row);
        }

        private void CheckGuess(string guess)
        {
            string guessUpper = guess.ToUpper();
            string currentUpper = currentWord.ToUpper();

            for (int i = 0; i < 5; i++)
            {
                var letter = guessUpper[i];
                var label = GetLabelFromGrid(attempt - 1, i);

                label.Text = letter.ToString().ToUpper();

                if (currentUpper[i] == letter)
                    label.BackColor = Color.Green;
                else if (currentUpper.Contains(letter))
                    label.BackColor = Color.Gold;
                else
                    label.BackColor = Color.Gray;

                label.ForeColor = Color.White;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Refresh();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text.Trim().ToUpper();
            if (guess.Length != 5)
            {
                MessageBox.Show("Guess must be 5 letters!");
                return;
            }

            attempt++;
            CheckGuess(guess);
            SaveGuessToDatabase(guess);

            if (guess.ToUpper() == currentWord.ToUpper())
            {
                MessageBox.Show("You guessed it!");
                btnSubmit.Enabled = false;
            }
            else if (attempt >= maxAttempts)
            {
                MessageBox.Show($"Out of attempts! The word was: {currentWord}");
                btnSubmit.Enabled = false;
            }

            txtGuess.Clear();
        }

        private void SaveGuessToDatabase(string guess)
        {
            using (var db = new WordleModel())
            {
                var g = new Guess
                {
                    GuessedWord = guess,
                    AttemptNumber = attempt,
                    Date = DateTime.Now
                };

                db.Guesses.Add(g);
                db.SaveChanges();
            }
        }
    }
}
