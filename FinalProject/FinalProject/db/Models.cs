using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.db
{
    public class Patient
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Visit> Visits { get; set; }
    }

    public class Doctor
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Specialization { get; set; }
        public ICollection<Visit> Visits { get; set; }
    }

    public class Visit
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime VisitDate { get; set; }
        public decimal Fee { get; set; }

        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}
