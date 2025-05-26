using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordleGame
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
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
    }
}
