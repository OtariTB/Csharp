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
    public partial class Stats : Form
    {
        private User _loggedInUser;
        public Stats(User user)
        {
            InitializeComponent();
            _loggedInUser = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Game game = new Game(_loggedInUser);
            this.Hide();
            game.Show();
            game.FormClosed += (s, args) => this.Close();
        }

        private void Stats_Load(object sender, EventArgs e)
        {

        }

        private void LoadStats()
        {
            using (var db = new WordleModel())
            {
                var userId = _loggedInUser.U_Id;
                var games = db.GameResult
                              .Where(g => g.UserId == userId)
                              .OrderByDescending(g => g.DatePlayed)
                              .ToList();

                int totalGames = games.Count;
                int wins = games.Count(g => g.IsWin);
                double winRate = totalGames == 0 ? 0 : (wins / (double)totalGames) * 100;

                int currentStreak = 0;
                foreach (var game in games)
                {
                    if (game.IsWin)
                        currentStreak++;
                    else
                        break;
                }

                totalGamesLabel.Text = $"{totalGames}";
                winLabel.Text = $"{winRate:F2}";
                CurrentStreakLabel.Text = $"{currentStreak}";
            }
        }
    }
}
