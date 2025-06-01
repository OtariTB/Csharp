using FinalC_.db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Data.SqlClient;
using static FinalC_.db.Models;

public class MedicalContext : DbContext
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Visit> Visits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-U99EOBB;Database=MedicalDb;Trusted_Connection=True;TrustServerCertificate=True;");

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>().HasData(
            new Doctor { Id = 1, FullName = "Dr. Ana Beridze", Specialization = "Cardiologist" },
            new Doctor { Id = 2, FullName = "Dr. Giorgi Kapanadze", Specialization = "Dermatologist" },
            new Doctor { Id = 3, FullName = "Dr. Nino Tsintsadze", Specialization = "Pediatrician" },
            new Doctor { Id = 4, FullName = "Dr. Giorgi Tsintsadze", Specialization = "Pediatrician" },
            new Doctor { Id = 5, FullName = "Dr. Lela Gogua", Specialization = "Pediatrician" },
            new Doctor { Id = 6, FullName = "Dr. Levan Kharabadze", Specialization = "Oncologist" },
            new Doctor { Id = 7, FullName = "Dr. Tamta Meskhidze", Specialization = "Gynecologist" },
            new Doctor { Id = 8, FullName = "Dr. Beka Mchedlidze", Specialization = "ENT" },
            new Doctor { Id = 9, FullName = "Dr. Irina Tushurashvili", Specialization = "Psychiatrist" },
            new Doctor { Id = 10, FullName = "Dr. Archil Bregvadze", Specialization = "Urologist" },
            new Doctor { Id = 11, FullName = "Dr. Nato Kipiani", Specialization = "Endocrinologist" },
            new Doctor { Id = 12, FullName = "Dr. Irakli Chanishvili", Specialization = "Radiologist" },
            new Doctor { Id = 13, FullName = "Dr. Tea Geguchadze", Specialization = "Rheumatologist" },
            new Doctor { Id = 14, FullName = "Dr. Giorgi Baramidze", Specialization = "Hematologist" },
            new Doctor { Id = 15, FullName = "Dr. Maka Chelidze", Specialization = "Immunologist" }
        );

        modelBuilder.Entity<Patient>().HasData(
            new Patient { Id = 1, FullName = "Lasha Qartvelishvili", BirthDate = new DateTime(1985, 5, 21) },
            new Patient { Id = 2, FullName = "Mariam Gelashvili", BirthDate = new DateTime(1992, 11, 2) },
            new Patient { Id = 3, FullName = "Lika Metreveli", BirthDate = new DateTime(1999, 6, 7) },
            new Patient { Id = 4, FullName = "Irakli Chikhladze", BirthDate = new DateTime(2000, 1, 12) },
            new Patient { Id = 5, FullName = "Salome Dumbadze", BirthDate = new DateTime(1992, 10, 30) },
            new Patient { Id = 6, FullName = "Nika Tsereteli", BirthDate = new DateTime(1987, 5, 18) },
            new Patient { Id = 7, FullName = "Keti Gogoladze", BirthDate = new DateTime(1994, 12, 4) },
            new Patient { Id = 8, FullName = "Tornike Abashidze", BirthDate = new DateTime(1996, 7, 29) },
            new Patient { Id = 9, FullName = "Mariam Tvalavadze", BirthDate = new DateTime(2001, 9, 10) },
            new Patient { Id = 10, FullName = "Luka Maisuradze", BirthDate = new DateTime(1995, 4, 22) },
            new Patient { Id = 11, FullName = "Nino Koberidze", BirthDate = new DateTime(1998, 3, 3) },
            new Patient { Id = 12, FullName = "Giorgi Tchubinishvili", BirthDate = new DateTime(1986, 6, 17) },
            new Patient { Id = 13, FullName = "Elene Sulaberidze", BirthDate = new DateTime(1993, 8, 26) },
            new Patient { Id = 14, FullName = "Zura Kacharava", BirthDate = new DateTime(2002, 2, 14) },
            new Patient { Id = 15, FullName = "Tamar Khutsishvili", BirthDate = new DateTime(1989, 12, 8) }
        );

        modelBuilder.Entity<Visit>().HasData(
            new Visit { Id = 1, PatientId = 1, DoctorId = 1, VisitDate = new DateTime(2024, 12, 1), Fee = 150 },
            new Visit { Id = 2, PatientId = 1, DoctorId = 2, VisitDate = new DateTime(2025, 1, 5), Fee = 200 },
            new Visit { Id = 3, PatientId = 2, DoctorId = 3, VisitDate = new DateTime(2025, 3, 15), Fee = 100 }
        );
    }
}