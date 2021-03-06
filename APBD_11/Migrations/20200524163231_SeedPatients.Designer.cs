﻿// <auto-generated />
using System;
using APBD_11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APBD_11.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20200524163231_SeedPatients")]
    partial class SeedPatients
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.4.20220.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APBD_11.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdDoctor")
                        .HasName("Enrollment_pk");

                    b.ToTable("Doctor","apbd_doctor");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "Frey@fray.com",
                            FirstName = "Jimmy",
                            LastName = "Frey"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "ONeill@oneil.com",
                            FirstName = "Erin",
                            LastName = "ONeill"
                        },
                        new
                        {
                            IdDoctor = 3,
                            Email = "Clements@clements.com",
                            FirstName = "Bobbie",
                            LastName = "Clements"
                        },
                        new
                        {
                            IdDoctor = 4,
                            Email = "Britton@britton.com",
                            FirstName = "Elena",
                            LastName = "Britton"
                        });
                });

            modelBuilder.Entity("APBD_11.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdMedicament")
                        .HasName("Medicament_pk");

                    b.ToTable("Medicament","apbd_doctor");
                });

            modelBuilder.Entity("APBD_11.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdPatient")
                        .HasName("Patient_pk");

                    b.ToTable("Patient","apbd_doctor");

                    b.HasData(
                        new
                        {
                            IdPatient = 1,
                            BirthDate = new DateTime(1980, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jan",
                            LastName = "Kowalczyk"
                        },
                        new
                        {
                            IdPatient = 2,
                            BirthDate = new DateTime(1986, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Anna",
                            LastName = "Power"
                        },
                        new
                        {
                            IdPatient = 3,
                            BirthDate = new DateTime(1930, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Saxon",
                            LastName = "Beattie"
                        },
                        new
                        {
                            IdPatient = 4,
                            BirthDate = new DateTime(1992, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Gia",
                            LastName = "Forrest"
                        });
                });

            modelBuilder.Entity("APBD_11.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("date");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription")
                        .HasName("Prescription_pk");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.ToTable("Prescription","apbd_doctor");
                });

            modelBuilder.Entity("APBD_11.Models.Prescription_Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdMedicament", "IdPrescription");

                    b.HasIndex("IdPrescription");

                    b.ToTable("Prescription_Medicament","apbd_doctor");
                });

            modelBuilder.Entity("APBD_11.Models.Prescription", b =>
                {
                    b.HasOne("APBD_11.Models.Doctor", "Doctor")
                        .WithMany("Prescription")
                        .HasForeignKey("IdDoctor")
                        .HasConstraintName("Doctor_Prescription")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APBD_11.Models.Patient", "Patient")
                        .WithMany("Prescription")
                        .HasForeignKey("IdPatient")
                        .HasConstraintName("Patient_Prescription")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APBD_11.Models.Prescription_Medicament", b =>
                {
                    b.HasOne("APBD_11.Models.Medicament", "Medicament")
                        .WithMany("Prescription_Medicament")
                        .HasForeignKey("IdMedicament")
                        .HasConstraintName("Medicament_Prescription_Medicament")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APBD_11.Models.Prescription", "Prescription")
                        .WithMany("Prescription_Medicament")
                        .HasForeignKey("IdPrescription")
                        .HasConstraintName("Prescription_Prescription_Medicament")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
