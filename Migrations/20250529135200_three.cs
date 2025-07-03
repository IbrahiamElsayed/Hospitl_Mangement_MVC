using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospitl_Mangement_MVC.Migrations
{
    /// <inheritdoc />
    public partial class three : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "First_Name", "Last_Name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "doc1", 0, "998ee1dd-2bc0-43fe-a837-7ca9481ba9ef", "ahmed@example.com", true, "Ahmed", "Youssef", false, null, "AHMED@EXAMPLE.COM", "AHMED@EXAMPLE.COM", null, null, false, null, "d08e174c-187d-410e-8df8-230f8019b0cd", false, "ahmed@example.com" },
                    { "pat1", 0, "f88a6b23-03c3-4f12-8bb1-d78d12c4e015", "sara@example.com", true, "Sara", "Mohamed", false, null, "SARA@EXAMPLE.COM", "SARA@EXAMPLE.COM", null, null, false, null, "c39e44d2-355e-46fd-8dee-35c0a74405ae", false, "sara@example.com" },
                    { "staff1", 0, "1c033f12-5a9b-4632-b2e8-3e1b3076c7ee", "mona@example.com", true, "Mona", "Ali", false, null, "MONA@EXAMPLE.COM", "MONA@EXAMPLE.COM", null, null, false, null, "8d7dfbdb-55e6-4a73-bd1d-4d6217c801f7", false, "mona@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "DepartmentName", "Describe", "DoctorId", "ImageURL", "Location", "StaffId" },
                values: new object[,]
                {
                    { 1, "Cardiology", "Heart-related treatments", null, null, "Building A", null },
                    { 2, "Neurology", "Brain and nervous system", null, null, "Building B", null }
                });

            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "MedicationID", "Dosage", "Frequenccy", "MedicationName", "PrescriptionID", "SideEffectes" },
                values: new object[] { 1, "500mg", "Twice a day", "Paracetamol", null, "Nausea" });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "PrescriptionID", "Duration", "MedicationID", "Quantity", "TreatmentID" },
                values: new object[] { 1, 5, 1, 10, 1 });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "DepartmentId", "Speciatly" },
                values: new object[] { "doc1", null, null });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "Birthdate", "Emergancy_Contact", "Gender", "TreatmentId" },
                values: new object[] { "pat1", "123 Main St", "1990-01-01", "01012345678", "Female", 1 });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "DepartmentId", "RoleId" },
                values: new object[] { "staff1", null, null });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentDate", "DoctorId", "PatientId", "Reason", "Status" },
                values: new object[] { 1, new DateTime(2025, 5, 30, 13, 51, 57, 548, DateTimeKind.Utc).AddTicks(3882), "doc1", "pat1", "Routine Check", "Scheduled" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "TreatmentId", "Diagnosis", "DoctorID", "EndDate", "PatientID", "SartDate", "TreatmentDescription" },
                values: new object[] { 1, "Flu", "doc1", new DateTime(2025, 5, 29, 13, 51, 57, 548, DateTimeKind.Utc).AddTicks(3742), "pat1", new DateTime(2025, 5, 24, 13, 51, 57, 548, DateTimeKind.Utc).AddTicks(3725), "Rest and hydration" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "PrescriptionID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: "staff1");

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "TreatmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "staff1");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: "doc1");

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: "pat1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "doc1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pat1");
        }
    }
}
