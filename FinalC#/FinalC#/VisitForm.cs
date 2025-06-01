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
using static FinalC_.db.Models;

namespace FinalC_
{
    public partial class VisitForm : Form
    {
        public VisitForm()
        {
            InitializeComponent();
        }

        private void VisitForm_Load(object sender, EventArgs e)
        {
            LoadVisits();
            LoadComboBoxes();
        }

        private void LoadVisits()
        {
            try
            {
                using (var context = new MedicalContext())
                {
                    var visitList = context.Visits.ToList();
                    dataGridView1.DataSource = visitList;
                    dataGridView1.Columns["Doctor"].Visible = false;
                    dataGridView1.Columns["Patient"].Visible = false;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Visits:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DoctorForm doctorform = new DoctorForm();
            doctorform.Show();
            this.Hide();
            doctorform.FormClosed += (s, args) => this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MainFormP patientform = new MainFormP();
            patientform.Show();
            this.Hide();
            patientform.FormClosed += (s, args) => this.Close();
        }
        private MedicalContext _context = new MedicalContext();

        private void LoadComboBoxes()
        {
            patientBox.DataSource = _context.Patients.ToList();
            patientBox.DisplayMember = "FullName";
            patientBox.ValueMember = "Id";

            doctorBox.DataSource = _context.Doctors.ToList();
            doctorBox.DisplayMember = "FullName";
            doctorBox.ValueMember = "Id";

            var filterDoctors = _context.Doctors.ToList();
            filterDoctors.Insert(0, new Doctor { Id = 0, FullName = "All Doctors" });
            doctorFilterBox.DataSource = filterDoctors;
            doctorFilterBox.DisplayMember = "FullName";
            doctorFilterBox.ValueMember = "Id";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int patientId = (int)patientBox.SelectedValue;
                int doctorId = (int)doctorBox.SelectedValue;
                DateTime visitDate = dateTimePicker1.Value.Date;
                decimal fee;

                if (!decimal.TryParse(txtFee.Text, out fee) || fee < 0 || fee > 1000)
                {
                    MessageBox.Show("Fee must be a number between 0 and 1000.");
                    return;
                }

                var newVisit = new Visit
                {
                    PatientId = patientId,
                    DoctorId = doctorId,
                    VisitDate = visitDate,
                    Fee = fee
                };

                _context.Visits.Add(newVisit);
                _context.SaveChanges();
                LoadVisits();
                MessageBox.Show("Visit added successfully.");
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
                    MessageBox.Show("Please select a visit to edit.");
                    return;
                }

                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var visit = _context.Visits.Find(id);

                if (visit == null) return;

                int patientId = (int)patientBox.SelectedValue;
                int doctorId = (int)doctorBox.SelectedValue;
                DateTime visitDate = dateTimePicker1.Value.Date;
                decimal fee;

                if (!decimal.TryParse(txtFee.Text, out fee) || fee < 0 || fee > 1000)
                {
                    MessageBox.Show("Fee must be a number between 0 and 1000.");
                    return;
                }

                visit.PatientId = patientId;
                visit.DoctorId = doctorId;
                visit.VisitDate = visitDate;
                visit.Fee = fee;

                _context.SaveChanges();
                LoadVisits();
                MessageBox.Show("Visit updated successfully.");
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
                    MessageBox.Show("Please select a visit to delete.");
                    return;
                }

                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var visit = _context.Visits.Find(id);

                if (visit != null)
                {
                    var confirm = MessageBox.Show("Delete selected visit?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        _context.Visits.Remove(visit);
                        _context.SaveChanges();
                        LoadVisits();
                        MessageBox.Show("Visit deleted.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void doctorFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
