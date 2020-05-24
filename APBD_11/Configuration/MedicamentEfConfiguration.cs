using APBD_11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_11.Configuration
{
    public class MedicamentEfConfiguration : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            
            builder.HasKey(x => x.IdMedicament)
                    .HasName("Medicament_pk");

            builder.ToTable("Medicament", "apbd_doctor");

            builder.Property(e => e.IdMedicament)
                    .ValueGeneratedNever();

            builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

            builder.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

            builder.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100);

            builder.HasMany(x => x.Prescription_Medicament)
                    .WithOne(x => x.Medicament);
            
        }
    }
}