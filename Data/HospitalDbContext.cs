using Hospitl_Mangement_MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hospitl_Mangement_MVC.Data
{
    public class HospitalDbContext : IdentityDbContext<BaseEntity>
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }

        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // تسمية الجداول
            modelBuilder.Entity<Doctor>().ToTable("Doctors");
            modelBuilder.Entity<Staff>().ToTable("Staffs");
            modelBuilder.Entity<Patient>().ToTable("Patients");

            // علاقة بين Treatment وPatient
            modelBuilder.Entity<Treatment>()
                .HasOne(p => p.Patient)
                .WithOne(t => t.Treatment)
                .OnDelete(DeleteBehavior.NoAction);

            // بيانات افتراضية Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, DepartmentName = "Cardiology", Location = "Building A", Describe = "Heart-related treatments" },
                new Department { Id = 2, DepartmentName = "Neurology", Location = "Building B", Describe = "Brain and nervous system" }
            );

            // بيانات افتراضية Doctors
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = "doc1",
                    First_Name = "Ahmed",
                    Last_Name = "Youssef",
                    Email = "ahmed@example.com",
                    UserName = "ahmed@example.com",
                    NormalizedUserName = "AHMED@EXAMPLE.COM",
                    NormalizedEmail = "AHMED@EXAMPLE.COM",
                    EmailConfirmed = true
                }
            );

            // بيانات افتراضية Staff
            modelBuilder.Entity<Staff>().HasData(
                new Staff
                {
                    Id = "staff1",
                    First_Name = "Mona",
                    Last_Name = "Ali",
                    Email = "mona@example.com",
                    UserName = "mona@example.com",
                    NormalizedUserName = "MONA@EXAMPLE.COM",
                    NormalizedEmail = "MONA@EXAMPLE.COM",
                    EmailConfirmed = true
                }
            );

            // بيانات افتراضية Patients
            modelBuilder.Entity<Patient>().HasData(
                new Patient
                {
                    Id = "pat1",
                    First_Name = "Sara",
                    Last_Name = "Mohamed",
                    Email = "sara@example.com",
                    UserName = "sara@example.com",
                    NormalizedUserName = "SARA@EXAMPLE.COM",
                    NormalizedEmail = "SARA@EXAMPLE.COM",
                    EmailConfirmed = true,
                    Address = "123 Main St",
                    Gender = "Female",
                    Emergancy_Contact = "01012345678",
                    Birthdate = "1990-01-01",
                    TreatmentId = 1
                }
            );

            // بيانات افتراضية Treatments
            modelBuilder.Entity<Treatment>().HasData(
                new Treatment
                {
                    TreatmentId = 1,
                    Diagnosis = "Flu",
                    TreatmentDescription = "Rest and hydration",
                    SartDate = DateTime.UtcNow.AddDays(-5),
                    EndDate = DateTime.UtcNow,
                    PatientID = "pat1",
                    DoctorID = "doc1"
                }
            );

            // بيانات افتراضية Medications
            modelBuilder.Entity<Medication>().HasData(
                new Medication
                {
                    MedicationID = 1,
                    MedicationName = "Paracetamol",
                    Dosage = "500mg",
                    Frequenccy = "Twice a day",
                    SideEffectes = "Nausea"
                }
            );

            // بيانات افتراضية Prescriptions
            modelBuilder.Entity<Prescription>().HasData(
                new Prescription
                {
                    PrescriptionID = 1,
                    TreatmentID = 1,
                    MedicationID = 1,
                    Quantity = 10,
                    Duration = 5
                }
            );

            // بيانات افتراضية Appointments
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment
                {
                    Id = 1,
                    AppointmentDate = DateTime.UtcNow.AddDays(1),
                    Status = "Scheduled",
                    Reason = "Routine Check",
                    DoctorId = "doc1",
                    PatientId = "pat1"
                }
            );

            // إضافة دور Admin
            var adminRoleId = "role-admin-id";
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = adminRoleId,
                Name = "Admin",
                NormalizedName = "ADMIN"
            });

            // إضافة مستخدم Admin
            var adminUserId = "user-admin-id";
            var hasher = new PasswordHasher<BaseEntity>();
            var adminUser = new BaseEntity
            {
                Id = adminUserId,
                UserName = "admin@example.com",
                NormalizedUserName = "ADMIN@EXAMPLE.COM",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true,
                First_Name = "System",
                Last_Name = "Administrator",
                PasswordHash = hasher.HashPassword(null, "Admin123!")
            };
            modelBuilder.Entity<BaseEntity>().HasData(adminUser);

            // ربط المستخدم Admin بالدور Admin
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = adminUserId
            });
        }
    }
}
