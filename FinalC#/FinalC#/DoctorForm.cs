using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace FinalC_
{
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            LoadDoctors();
        }
        private void LoadDoctors()
        {
            try
            {
                using (var context = new MedicalContext())
                {
                    var doctorList = context.Doctors.Include(d => d.Visits).ToList();
                    dataGridView1.DataSource = doctorList;
                    dataGridView1.Columns["Visits"].Visible = false;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Doctors:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MainFormP patientform = new MainFormP();
            patientform.Show();
            this.Hide();
            patientform.FormClosed += (s, args) => this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            VisitForm visitform = new VisitForm();
            visitform.Show();
            this.Hide();
            visitform.FormClosed += (s, args) => this.Close();
        }
    }
}
