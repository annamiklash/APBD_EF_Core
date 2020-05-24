using APBD_11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_11.Configuration
{
    public class DoctorEfConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
         
            builder.HasKey(x => x.IdDoctor)
                    .HasName("Enrollment_pk");

            builder.ToTable("Doctor", "apbd_doctor");
                
            builder.Property(e => e.IdDoctor).
                    ValueGeneratedNever();

            builder.Property(x => x.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

            builder.Property(x => x.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

            builder.Property(x => x.Email)
                    .IsRequired()
                    .HasMaxLength(100);
                
            builder.HasMany(d => d.Prescription)
                    .WithOne(x => x.Doctor);
            
        }
    }
}