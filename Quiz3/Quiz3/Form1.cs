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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadProducts()
        {
            using (var db = new StoredbEntities())
            {
                var products = db.Products
                    .Select(p => new
                    {
                        p.Id,
                        p.ProductName,
                        p.SupplierId,
                        p.UnitPrice,
                        p.Package,
                        p.IsDiscontinued
                    })
                    .ToList();

                dataGridView1.DataSource = products;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StoredbEntities db = new StoredbEntities();
            var products = db.Products.ToList();
            dataGridView1.DataSource = products;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 customerForm = new Form2();
            this.Hide();
            customerForm.Show();
            customerForm.FormClosed += (s, args) => this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (var db = new StoredbEntities())
            {
                var newProduct = new Product
                {
                    ProductName = txtpName.Text,
                    SupplierId = int.TryParse(txtSID.Text, out int supplierId) ? supplierId : (int?)null,
                    UnitPrice = decimal.TryParse(txtPrice.Text, out decimal price) ? price : (decimal?)null,
                    Package = txtPackage.Text,
                    IsDiscontinued = isDiscBox.Checked

                };
                db.Products.Add(newProduct);
                db.SaveChanges();
            }
            MessageBox.Show("Product added successfully.");
            LoadProducts();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to edit.");
                return;
            }

            int productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            using (var db = new StoredbEntities())
            {
                var product = db.Products.Find(productId);

                if (product != null)
                {
                    product.ProductName = txtpName.Text;
                    product.SupplierId = int.TryParse(txtSID.Text, out int supplierId) ? supplierId : (int?)null;
                    product.UnitPrice = decimal.TryParse(txtPrice.Text, out decimal price) ? price : (decimal?)null;
                    product.Package = txtPackage.Text;
                    product.IsDiscontinued = isDiscBox.Checked;

                    db.SaveChanges();
                    MessageBox.Show("Product updated successfully.");
                    LoadProducts();
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            int productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            var confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            using (var db = new StoredbEntities())
            {
                var product = db.Products.Find(productId);

                if (product != null)
                {
                    db.Products.Remove(product);
                    db.SaveChanges();
                    MessageBox.Show("Product deleted successfully.");
                    LoadProducts();
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
