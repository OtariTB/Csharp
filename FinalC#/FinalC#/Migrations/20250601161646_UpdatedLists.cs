using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalC_.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedLists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "FullName", "Specialization" },
                values: new object[,]
                {
                    { 5, "Dr. Lela Gogua", "Pediatrician" },
                    { 6, "Dr. Levan Kharabadze", "Oncologist" },
                    { 7, "Dr. Tamta Meskhidze", "Gynecologist" },
                    { 8, "Dr. Beka Mchedlidze", "ENT" },
                    { 9, "Dr. Irina Tushurashvili", "Psychiatrist" },
                    { 10, "Dr. Archil Bregvadze", "Urologist" },
                    { 11, "Dr. Nato Kipiani", "Endocrinologist" },
                    { 12, "Dr. Irakli Chanishvili", "Radiologist" },
                    { 13, "Dr. Tea Geguchadze", "Rheumatologist" },
                    { 14, "Dr. Giorgi Baramidze", "Hematologist" },
                    { 15, "Dr. Maka Chelidze", "Immunologist" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "BirthDate", "FullName" },
                values: new object[,]
                {
                    { 3, new DateTime(1999, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lika Metreveli" },
                    { 4, new DateTime(2000, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Irakli Chikhladze" },
                    { 5, new DateTime(1992, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salome Dumbadze" },
                    { 6, new DateTime(1987, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nika Tsereteli" },
                    { 7, new DateTime(1994, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keti Gogoladze" },
                    { 8, new DateTime(1996, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tornike Abashidze" },
                    { 9, new DateTime(2001, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariam Tvalavadze" },
                    { 10, new DateTime(1995, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luka Maisuradze" },
                    { 11, new DateTime(1998, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nino Koberidze" },
                    { 12, new DateTime(1986, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giorgi Tchubinishvili" },
                    { 13, new DateTime(1993, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elene Sulaberidze" },
                    { 14, new DateTime(2002, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zura Kacharava" },
                    { 15, new DateTime(1989, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tamar Khutsishvili" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
