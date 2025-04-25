using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WordleGame
{
    public partial class Form1 : Form
    {
        private WordleDBEntities _db = new WordleDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            string password = passBox.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter Email and Password.");
                return;
            }
            var user = _db.Users.FirstOrDefault(x => x.Email == email && x.Pass == password);
            if (user != null)
            {
                MessageBox.Show("Login Successful");
                GameForm main = new GameForm();
                this.Hide();
                main.Show();
                main.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Email Or Password");
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            string password = passBox.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter Email and Password.");
                return;
            }

            try
            {
                _db.AddUser(email, password);
                MessageBox.Show("Account Successfully Ceated! \n You can Log In now!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
