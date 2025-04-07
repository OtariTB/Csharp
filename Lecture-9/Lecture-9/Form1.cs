using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VynilStoreEntities db = new VynilStoreEntities();
            var album = db.Albums.ToList();
            dataGridView1.DataSource = album;
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            VynilStoreEntities db = new VynilStoreEntities();
            var album2 = db.Albums.ToList();
            var filteredAlbums = db.Albums.Where(x => x.inStock > 10).ToList();
            dataGridView1.DataSource = filteredAlbums;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            VynilStoreEntities db = new VynilStoreEntities();
            var album = db.Albums.ToList();
            dataGridView1.DataSource = album;
        }
    }
}
