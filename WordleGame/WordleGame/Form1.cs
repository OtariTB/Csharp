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
        private WordleModel
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
            

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter Email and Password.");
                return;
            }
            var user = _db.Users.FirstOrDefault(x => x.Email == email);
            if (user != null)
            {
                MessageBox.Show("You Already Have an Account ! \n Loading Log In Page.");
                Form3 loginform = new Form3();
                this.Hide();
                loginform.Show();
                loginform.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("There is No Account with this Email Address \n Loading Sign Up page !");
                Form2 main = new Form2();
                this.Hide();
                main.Show();
                main.FormClosed += (s, args) => this.Close();

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form3 loginform = new Form3();
            this.Hide();
            loginform.Show();
            loginform.FormClosed += (s, args) => this.Close();
        }
    }
}
