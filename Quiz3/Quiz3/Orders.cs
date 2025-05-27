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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 CustomerForm = new Form2();
            this.Hide();
            CustomerForm.Show();
            CustomerForm.FormClosed += (s, args) => this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Suppliers productForm = new Suppliers();
            this.Hide();
            productForm.Show();
            productForm.FormClosed += (s, args) => this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            OrderItems productForm = new OrderItems();
            this.Hide();
            productForm.Show();
            productForm.FormClosed += (s, args) => this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 productForm = new Form1();
            this.Hide();
            productForm.Show();
            productForm.FormClosed += (s, args) => this.Close();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            StoredbEntities db = new StoredbEntities();
            var orders = db.Orders.ToList();
            dataGridView1.DataSource = orders;
        }
    }
}
