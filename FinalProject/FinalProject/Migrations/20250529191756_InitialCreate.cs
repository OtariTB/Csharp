using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Specialization = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(nullable: false),
                    DoctorId = table.Column<int>(nullable: false),
                    VisitDate = table.Column<DateTime>(nullable: false),
                    Fee = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visits_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Visits_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "FullName", "Specialization" },
                values: new object[,]
                {
                    { 1, "Dr. Ana Beridze", "Cardiologist" },
                    { 2, "Dr. Giorgi Kapanadze", "Dermatologist" },
                    { 3, "Dr. Nino Tsintsadze", "Pediatrician" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "BirthDate", "FullName" },
                values: new object[,]
                {
                    { 1, new DateTime(1985, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lasha Qartvelishvili" },
                    { 2, new DateTime(1992, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariam Gelashvili" }
                });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "Id", "DoctorId", "Fee", "PatientId", "VisitDate" },
                values: new object[] { 1, 1, 150m, 1, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "Id", "DoctorId", "Fee", "PatientId", "VisitDate" },
                values: new object[] { 2, 2, 200m, 1, new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "Id", "DoctorId", "Fee", "PatientId", "VisitDate" },
                values: new object[] { 3, 3, 100m, 2, new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Visits_DoctorId",
                table: "Visits",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_PatientId",
                table: "Visits",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
