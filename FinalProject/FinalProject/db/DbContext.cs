using FinalProject.db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Data.SqlClient;

public class MedicalContext : DbContext
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Visit> Visits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MedicalDb;Trusted_Connection=True;");

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>().HasData(
            new Doctor { Id = 1, FullName = "Dr. Ana Beridze", Specialization = "Cardiologist" },
            new Doctor { Id = 2, FullName = "Dr. Giorgi Kapanadze", Specialization = "Dermatologist" },
            new Doctor { Id = 3, FullName = "Dr. Nino Tsintsadze", Specialization = "Pediatrician" },
            new Doctor { Id = 4, FullName = "Dr. Giorgi Tsintsadze", Specialization = "Pediatrician" }
        );

        modelBuilder.Entity<Patient>().HasData(
            new Patient { Id = 1, FullName = "Lasha Qartvelishvili", BirthDate = new DateTime(1985, 5, 21) },
            new Patient { Id = 2, FullName = "Mariam Gelashvili", BirthDate = new DateTime(1992, 11, 2) }
        );

        modelBuilder.Entity<Visit>().HasData(
            new Visit { Id = 1, PatientId = 1, DoctorId = 1, VisitDate = new DateTime(2024, 12, 1), Fee = 150 },
            new Visit { Id = 2, PatientId = 1, DoctorId = 2, VisitDate = new DateTime(2025, 1, 5), Fee = 200 },
            new Visit { Id = 3, PatientId = 2, DoctorId = 3, VisitDate = new DateTime(2025, 3, 15), Fee = 100 }
        );
    }
}
