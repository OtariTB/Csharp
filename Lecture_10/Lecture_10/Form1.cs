using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_10
{
    public partial class Form1 : Form
    {
        private VynilStoreEntities _db = new VynilStoreEntities();
        public Form1()
        {
            InitializeComponent();
            loadGenreIds();
        }

        private void loadGenreIds()
        {
            GenreIdBox.DataSource = _db.Genres.ToList();
            GenreIdBox.DisplayMember = "Genre_ID";
            GenreIdBox.ValueMember = "Genre_ID";
        }
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Genres.ToList();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Genre newgenre = new Genre()
            {
                GenreName = GenreNameBox.Text,

            };
            _db.Genres.Add(newgenre);
            _db.SaveChanges();
            dataGridView1.DataSource = _db.Genres.ToList();
            loadGenreIds();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int id = (int)GenreIdBox.SelectedValue;
            Genre genre = _db.Genres.FirstOrDefault(x => x.Genre_ID == id);
            genre.GenreName = GenreNameBox.Text;
            _db.SaveChanges();
            dataGridView1.DataSource = _db.Genres.ToList();
            loadGenreIds();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            int id = (int)GenreIdBox.SelectedValue;
            Genre genre = _db.Genres.FirstOrDefault(x => x.Genre_ID == id);
            _db.Genres.Remove(genre);
            _db.SaveChanges();
            dataGridView1.DataSource = _db.Genres.ToList();
            loadGenreIds();
        }
    }
}
