using APBD_11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_11.Configuration
{
    public class PrescriptionMedicamentEfConfiguration : IEntityTypeConfiguration<Prescription_Medicament>
    {
        public void Configure(EntityTypeBuilder<Prescription_Medicament> builder)
        {
            
            builder.HasKey(e => new {e.IdMedicament, e.IdPrescription});

            builder.Property(e => e.IdMedicament);

            builder.Property(e => e.IdPrescription);

            builder.ToTable("Prescription_Medicament", "apbd_doctor");

            builder.Property(x => x.Dose);

            builder.Property(x => x.Details)
                .HasMaxLength(100)
                .IsRequired();
                
            builder.HasOne(x => x.Prescription)
                    .WithMany(x => x.Prescription_Medicament)
                    .HasForeignKey(x => x.IdPrescription)
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired()
                    .HasConstraintName("Prescription_Prescription_Medicament");
                
            builder.HasOne(x => x.Medicament)
                    .WithMany(x => x.Prescription_Medicament)
                    .HasForeignKey(x => x.IdMedicament)
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired()
                    .HasConstraintName("Medicament_Prescription_Medicament");
                
        }
    }
}