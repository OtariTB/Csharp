using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalC_.db.Models;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

namespace FinalC_
{
    public partial class MainFormP : Form
    {
        public MainFormP()
        {
            InitializeComponent();
        }

        private void MainFormP_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }
        private void LoadPatients()
        {
            try
            {
                using (var context = new MedicalContext())
                {
                    var patientList = context.Patients.Include(p => p.Visits).ToList();
                    dataGridView1.DataSource = patientList;
                    dataGridView1.Columns["Visits"].Visible = false;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load patients:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DoctorForm doctorform = new DoctorForm();
            doctorform.Show();
            this.Hide();
            doctorform.FormClosed += (s, args) => this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            VisitForm visitform = new VisitForm();
            visitform.Show();
            this.Hide();
            visitform.FormClosed += (s, args) => this.Close();
        }

        private MedicalContext _context = new MedicalContext();

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtFName.Text.Trim();
                DateTime birthDate = dateTimePicker1.Value.Date;

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Full Name is required.", "Validation Error");
                    return;
                }

                if (birthDate > DateTime.Now)
                {
                    MessageBox.Show("Birthdate cannot be in the future.", "Validation Error");
                    return;
                }

                var newPatient = new Patient
                {
                    FullName = name,
                    BirthDate = birthDate
                };

                _context.Patients.Add(newPatient);
                _context.SaveChanges();
                LoadPatients();
                MessageBox.Show("Patient added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Please select a patient to delete.");
                    return;
                }

                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var patient = _context.Patients.Find(id);

                if (patient != null)
                {
                    var confirm = MessageBox.Show(
                        $"Are you sure you want to delete patient: {patient.FullName}?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirm == DialogResult.Yes)
                    {
                        _context.Patients.Remove(patient);
                        _context.SaveChanges();
                        LoadPatients();
                        MessageBox.Show("Patient deleted successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void edtBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Please select a patient to edit.");
                    return;
                }

                string name = txtFName.Text.Trim();
                DateTime birthDate = dateTimePicker1.Value.Date;

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Full Name is required.", "Validation Error");
                    return;
                }

                if (birthDate > DateTime.Now)
                {
                    MessageBox.Show("Birthdate cannot be in the future.", "Validation Error");
                    return;
                }

                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var patient = _context.Patients.Find(id);

                if (patient != null)
                {
                    patient.FullName = name;
                    patient.BirthDate = birthDate;

                    _context.SaveChanges();
                    LoadPatients();
                    MessageBox.Show("Patient updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
