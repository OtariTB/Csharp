using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalC_.db
{
    public class Models
    {
        public class Patient
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public DateTime BirthDate { get; set; }
            public ICollection<Visit> Visits { get; set; }
            public decimal TotalFee => Visits?.Sum(x => x.Fee) ?? 0;
        }

        public class Doctor
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public string Specialization { get; set; }
            public ICollection<Visit> Visits { get; set; }
            public int TotalVisits => Visits?.Count() ?? 0;
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
}
