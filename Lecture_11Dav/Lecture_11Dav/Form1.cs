using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_11Dav
{
    public partial class Form1 : Form
    {
        private WordleDbContainer _db1 = new WordleDbContainer();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string word = Wordbox.Text;

            _db1.Words.Add()
        }
    }
}
