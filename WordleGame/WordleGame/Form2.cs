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
    public partial class Form2 : Form
    {
        private WordleDBEntities _db = new WordleDBEntities();
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
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
                Form3 loginform = new Form3();
                this.Hide();
                loginform.Show();
                loginform.FormClosed += (s, args) => this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
