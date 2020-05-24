using APBD_11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_11.Configuration
{
    public class PrescriptionEfConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            
            builder.HasKey(x => x.IdPrescription)
                    .HasName("Prescription_pk");

            builder.ToTable("Prescription", "apbd_doctor");
                
            builder.Property(e => e.IdPrescription)
                    .ValueGeneratedNever()
                    .IsRequired();

            builder.Property(x => x.Date)
                    .IsRequired()
                    .HasColumnType("date");

            builder.Property(x => x.DueDate)
                    .IsRequired()
                    .HasColumnType("date");
            
            builder.HasOne(x => x.Doctor)
                    .WithMany(x => x.Prescription)
                    .HasForeignKey(x => x.IdDoctor)
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired()
                    .HasConstraintName("Doctor_Prescription");
            
            builder.HasOne(x => x.Patient)
                    .WithMany(x => x.Prescription)
                    .HasForeignKey(x => x.IdPatient)
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired()
                    .HasConstraintName("Patient_Prescription");
            
                
            builder.HasMany(x => x.Prescription_Medicament)
                    .WithOne(x => x.Prescription);
          

        }
    }
}