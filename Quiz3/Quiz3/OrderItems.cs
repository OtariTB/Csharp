using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz3
{
    public partial class OrderItems : Form
    {
        public OrderItems()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void OrderItems_Load(object sender, EventArgs e)
        {
            StoredbEntities db = new StoredbEntities();
            var orderitems = db.OrderItems.ToList();
            dataGridView1.DataSource = orderitems;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Form2 CustomerForm = new Form2();
            this.Hide();
            CustomerForm.Show();
            CustomerForm.FormClosed += (s, args) => this.Close();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Orders productForm = new Orders();
            this.Hide();
            productForm.Show();
            productForm.FormClosed += (s, args) => this.Close();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Suppliers productForm = new Suppliers();
            this.Hide();
            productForm.Show();
            productForm.FormClosed += (s, args) => this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Form1 productForm = new Form1();
            this.Hide();
            productForm.Show();
            productForm.FormClosed += (s, args) => this.Close();
        }
    }
}
