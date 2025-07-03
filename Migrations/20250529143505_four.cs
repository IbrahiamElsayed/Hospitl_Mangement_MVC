using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospitl_Mangement_MVC.Migrations
{
    /// <inheritdoc />
    public partial class four : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppointmentDate",
                value: new DateTime(2025, 5, 30, 14, 34, 58, 480, DateTimeKind.Utc).AddTicks(7658));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "role-admin-id", null, "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "doc1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "da8547f4-6e66-40c9-bf20-3082428cef59", "c7cea023-e44d-400f-99aa-c2d1d59d064c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pat1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8e08696-dc73-4868-92ea-ccd2e13c6340", "56c9d539-1449-4dea-b05d-23ddf12ed621" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "staff1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fa3ac6a7-1d7b-46db-a1e9-8153e1e5bee9", "291b116a-1b1c-4b30-bbcf-e1e5fafa0dcd" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "First_Name", "Last_Name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "user-admin-id", 0, "55876e70-386b-4b36-8c2f-5111b5742616", "admin@example.com", true, "System", "Administrator", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBQBXC/iDDJfOTKDzhejIjS7TU/fgky5Y7XYsMOmnYgsDcjwLyHo2MoKTxKfnRDqEw==", null, false, null, "4724f3e6-b7dd-4fb7-a0bb-9ce8e89b284e", false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "TreatmentId",
                keyValue: 1,
                columns: new[] { "EndDate", "SartDate" },
                values: new object[] { new DateTime(2025, 5, 29, 14, 34, 58, 480, DateTimeKind.Utc).AddTicks(7533), new DateTime(2025, 5, 24, 14, 34, 58, 480, DateTimeKind.Utc).AddTicks(7520) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "role-admin-id", "user-admin-id" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "role-admin-id", "user-admin-id" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role-admin-id");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-admin-id");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppointmentDate",
                value: new DateTime(2025, 5, 30, 13, 51, 57, 548, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "doc1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "998ee1dd-2bc0-43fe-a837-7ca9481ba9ef", "d08e174c-187d-410e-8df8-230f8019b0cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "pat1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f88a6b23-03c3-4f12-8bb1-d78d12c4e015", "c39e44d2-355e-46fd-8dee-35c0a74405ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "staff1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1c033f12-5a9b-4632-b2e8-3e1b3076c7ee", "8d7dfbdb-55e6-4a73-bd1d-4d6217c801f7" });

            migrationBuilder.UpdateData(
                table: "Treatments",
                keyColumn: "TreatmentId",
                keyValue: 1,
                columns: new[] { "EndDate", "SartDate" },
                values: new object[] { new DateTime(2025, 5, 29, 13, 51, 57, 548, DateTimeKind.Utc).AddTicks(3742), new DateTime(2025, 5, 24, 13, 51, 57, 548, DateTimeKind.Utc).AddTicks(3725) });
        }
    }
}
