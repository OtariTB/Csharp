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
            LoadDoctorFilterComboBox();
            LoadVisits();
            LoadComboBoxes();
        }

        private int currentPage = 1;
        private int pageSize = 10;

        private void LoadVisits()
        {
            try
            {
                using (var context = new MedicalContext())
                {
                    int skip = (currentPage - 1) * pageSize;

                    var visitList = context.Visits
                        .OrderBy(d => d.Id)
                        .Skip(skip)
                        .Take(pageSize)
                        .ToList();
                    dataGridView1.DataSource = visitList;
                    dataGridView1.Columns["Doctor"].Visible = false;
                    dataGridView1.Columns["Patient"].Visible = false;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    pageLabel.Text = $"{currentPage}";
                    btnPrevPage.Enabled = currentPage > 1;
                    btnNextPage.Enabled = skip + pageSize < context.Doctors.Count();
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

        private void LoadDoctorFilterComboBox()
        {
            using (var context = new MedicalContext())
            {
                var doctors = context.Doctors.ToList();

                doctorFilterBox.DataSource = doctors;
                doctorFilterBox.DisplayMember = "FullName";
                doctorFilterBox.ValueMember = "Id";
                doctorFilterBox.SelectedIndex = 0;
            }
        }

        private void FilterVisitsByDoctor()
        {

            var selectedDoctor = doctorFilterBox.SelectedItem as Doctor;
            if (selectedDoctor == null)
            {
                MessageBox.Show("Selected item is not a valid doctor.");
                return;
            }

            int selectedDoctorId = selectedDoctor.Id;

            using (var context = new MedicalContext())
            {
                var visits = context.Visits
                    .Include(v => v.Doctor)
                    .Include(v => v.Patient)
                    .Where(v => v.DoctorId == selectedDoctorId)
                    .Select(v => new
                    {
                        v.Id,
                        Patient = v.Patient.FullName,
                        Doctor = v.Doctor.FullName,
                        v.VisitDate,
                        v.Fee
                    })
                    .ToList();

                dataGridView1.DataSource = visits;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void doctorFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterVisitsByDoctor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doctorFilterBox.SelectedIndex = 0;
            LoadVisits();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FilterVisitsByDate();
        }

        private void FilterVisitsByDate()
        {
            if (!dateTimePickerFilter.Checked)
            {
                MessageBox.Show("Please select a date to filter by.");
                return;
            }

            DateTime selectedDate = dateTimePickerFilter.Value.Date;

            using (var context = new MedicalContext())
            {
                var visits = context.Visits
                    .Include(v => v.Doctor)
                    .Include(v => v.Patient)
                    .Where(v => v.VisitDate.Date == selectedDate)
                    .Select(v => new
                    {
                        v.Id,
                        Patient = v.Patient.FullName,
                        Doctor = v.Doctor.FullName,
                        v.VisitDate,
                        v.Fee
                    })
                    .ToList();

                dataGridView1.DataSource = visits;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadVisits();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadVisits();
        }
    }
}
