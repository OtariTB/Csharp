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
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form2 main = new Form2();
            this.Hide();
            main.Show();
            main.FormClosed += (s, args) => this.Close();
        }
    }
}
