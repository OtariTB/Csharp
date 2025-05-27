using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StoredbEntities db = new StoredbEntities();
            var customers = db.Customers.ToList();
            dataGridView1.DataSource = customers;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 productForm = new Form1();
            this.Hide();
            productForm.Show();
            productForm.FormClosed += (s, args) => this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (var db = new StoredbEntities())
            {
                Customer customer = new Customer();
                var newCustomer = new Customer
                {
                    FirstName = txtfName.Text,
                    LastName = txtlName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Phone = txtPhone.Text
                };

                db.Customers.Add(newCustomer);
                db.SaveChanges();
            }
            MessageBox.Show("Customer added successfully.");
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            using (var db = new StoredbEntities())
            {
                var customers = db.Customers
                    .Select(c => new
                    {
                        c.Id,
                        c.FirstName,
                        c.LastName,
                        c.City,
                        c.Country,
                        c.Phone
                    })
                    .ToList();

                dataGridView1.DataSource = customers;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a customer to edit.");
                return;
            }

            int customerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            using (var db = new StoredbEntities())
            {
                var customer = db.Customers.Find(customerId);

                if (customer != null)
                {
                    customer.FirstName = txtfName.Text;
                    customer.LastName = txtlName.Text;
                    customer.City = txtCity.Text;
                    customer.Country = txtCountry.Text;
                    customer.Phone = txtPhone.Text;

                    db.SaveChanges();
                    MessageBox.Show("Customer updated successfully.");
                    LoadCustomers();
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            int customerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            var confirm = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            using (var db = new StoredbEntities())
            {
                var customer = db.Customers.Find(customerId);
                if (customer != null)
                {
                    db.Customers.Remove(customer);
                    db.SaveChanges();
                    MessageBox.Show("Customer deleted successfully.");
                    LoadCustomers();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Orders OrderForm = new Orders();
            this.Hide();
            OrderForm.Show();
            OrderForm.FormClosed += (s, args) => this.Close();
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
    }
}
