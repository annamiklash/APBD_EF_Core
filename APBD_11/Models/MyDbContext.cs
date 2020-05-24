using APBD_11.Configuration;

using Microsoft.EntityFrameworkCore;

namespace APBD_11.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Medicament> Medicament { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Prescription_Medicament> Prescription_Medicament { get; set; }
        public DbSet<Prescription> Prescription { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public MyDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DoctorEfConfiguration());

            modelBuilder.ApplyConfiguration(new PatientEfConfiguration());

            modelBuilder.ApplyConfiguration(new PrescriptionEfConfiguration());

            modelBuilder.ApplyConfiguration(new MedicamentEfConfiguration());

            modelBuilder.ApplyConfiguration(new PrescriptionMedicamentEfConfiguration());

            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }
    }
}