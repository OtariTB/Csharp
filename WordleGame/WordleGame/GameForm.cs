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
    public partial class GameForm : Form
    {
        private User _loggedInUser;
        public GameForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Game game = new Game(_loggedInUser);
            this.Hide();
            game.Show();
            game.FormClosed += (s, args) => this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form2 main = new Form2();
            this.Hide();
            main.Show();
            main.FormClosed += (s, args) => this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
