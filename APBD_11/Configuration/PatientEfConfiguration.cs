using APBD_11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_11.Configuration
{
    public class PatientEfConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
     
            builder.HasKey(x => x.IdPatient)
                    .HasName("Patient_pk");

            builder.ToTable("Patient", "apbd_doctor");

            builder.Property(e => e.IdPatient)
                    .ValueGeneratedNever();
                    

            builder.Property(x => x.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

            builder.Property(x => x.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

            builder.Property(x => x.BirthDate)
                    .IsRequired()
                    .HasColumnType("date");

            builder.HasMany(d => d.Prescription)
                    .WithOne(x => x.Patient);
            
        }
    }
}