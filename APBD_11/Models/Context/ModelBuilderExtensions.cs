using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace APBD_11.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var doctors = GenerateDoctors();
            
            var patients = GeneratePatients();
            
            var medicaments = GenerateMedicaments();
            
            var prescriptions = GeneratePrescriptions();
            
            var prescriptionMedicaments = GenerateMedicament_Prescriptions();


            SeedDoctorTable(doctors, modelBuilder);
         
            SeedPatientsTable(patients, modelBuilder);
  
            SeedMedicamentsTable(medicaments, modelBuilder);
           
            SeedPrescriptionsTable(prescriptions, modelBuilder);
           
            SeedPrescriptionMedicamentsTable(prescriptionMedicaments, modelBuilder);
           
        }

        private static void SeedDoctorTable(IEnumerable<Doctor> doctors, ModelBuilder modelBuilder)
        {
            foreach (var doctor in doctors)
            {
                modelBuilder
                    .Entity<Doctor>()
                    .HasData(doctor);
            }
        }

        private static void SeedPatientsTable(IEnumerable<Patient> patients, ModelBuilder modelBuilder)
        {
            foreach (var patient in patients)
            {
                modelBuilder
                    .Entity<Patient>()
                    .HasData(patient);
            }
        }

        private static void SeedMedicamentsTable(IEnumerable<Medicament> medicaments, ModelBuilder modelBuilder)
        {
            foreach (var medicament in medicaments)
            {
                modelBuilder
                    .Entity<Medicament>()
                    .HasData(medicament);
            }
        }

        private static void SeedPrescriptionsTable(IEnumerable<Prescription> prescriptions, ModelBuilder modelBuilder)
        {
            foreach (var prescription in prescriptions)
            {
                modelBuilder.Entity<Prescription>()
                    .HasData(prescription);
            }
        }

        private static void SeedPrescriptionMedicamentsTable(IEnumerable<Prescription_Medicament> prescriptionMedicaments, ModelBuilder modelBuilder)
        {
            foreach (var prescriptionMedicament in prescriptionMedicaments)
            {
                modelBuilder.Entity<Prescription_Medicament>()
                    .HasData(prescriptionMedicament);
            }
        }

        private static IEnumerable<Prescription_Medicament> GenerateMedicament_Prescriptions()
        {
            return new List<Prescription_Medicament>
            {
                new Prescription_Medicament
                {
                    IdMedicament = 1,
                    IdPrescription = 1,
                    Dose = 30,
                    Details = "details 1"
                },
                new Prescription_Medicament
                {
                    IdMedicament = 1,
                    IdPrescription = 2,
                    Dose = 15,
                    Details = "details 2"
                },
                new Prescription_Medicament
                {
                    IdMedicament = 2,
                    IdPrescription = 3,
                    Dose = 100,
                    Details = "details 3"
                },
                new Prescription_Medicament
                {
                    IdMedicament = 3,
                    IdPrescription = 4,
                    Dose = 20,
                    Details = "details 4"
                },
                new Prescription_Medicament
                {
                    IdMedicament = 5, 
                    IdPrescription = 6, 
                    Dose = 10, 
                    Details = "details 5"
                }
                , new Prescription_Medicament
                {
                    IdMedicament = 6, 
                    IdPrescription = 7, 
                    Dose = 5, 
                    Details = "details 6"
                }
                , new Prescription_Medicament
                {
                    IdMedicament = 6, 
                    IdPrescription = 8, 
                    Dose = 14, 
                    Details = "details 7"
                }
                , new Prescription_Medicament
                {
                    IdMedicament = 6, 
                    IdPrescription = 9, 
                    Dose = 100, 
                    Details = "details 8"
                },
                new Prescription_Medicament
                {
                    IdMedicament = 3, 
                    IdPrescription = 10, 
                    Dose = 8, 
                    Details = "details 9"
                },
                new Prescription_Medicament
                {
                    IdMedicament = 3, 
                    IdPrescription = 5, 
                    Dose = 10, 
                    Details = "details 10"
                },
                new Prescription_Medicament
                {
                    IdMedicament = 4, 
                    IdPrescription = 2, 
                    Dose = 21, 
                    Details = "details 11"
                }
            };
        }

        private static IEnumerable<Prescription> GeneratePrescriptions()
        {
            return new List<Prescription>
            {
                new Prescription()
                {
                    IdPrescription = 1, Date = DateTime.ParseExact("20.04.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture), 
                    DueDate = DateTime.ParseExact("22.06.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    IdPatient = 1, IdDoctor = 1
                },
                new Prescription()
                {
                    IdPrescription = 2, Date = DateTime.ParseExact("28.04.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture), 
                    DueDate = DateTime.ParseExact("28.06.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    IdPatient = 1, IdDoctor = 1
                },
                new Prescription()
                {
                    IdPrescription = 3, Date = DateTime.ParseExact("15.05.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture), 
                    DueDate = DateTime.ParseExact("15.06.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    IdPatient = 1, IdDoctor = 2
                },
                new Prescription()
                {
                    IdPrescription = 4, Date = DateTime.ParseExact("13.04.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture), 
                    DueDate = DateTime.ParseExact("06.06.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    IdPatient = 2, IdDoctor = 1
                },
                new Prescription()
                {
                    IdPrescription = 5, Date = DateTime.ParseExact("27.04.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture), 
                    DueDate = DateTime.ParseExact("18.06.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    IdPatient = 2, IdDoctor = 3
                },
                new Prescription()
                {
                    IdPrescription = 6, Date = DateTime.ParseExact("24.05.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture), 
                    DueDate = DateTime.ParseExact("02.08.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    IdPatient = 3, IdDoctor = 3
                },
                new Prescription
                {
                    IdPrescription = 7, Date = DateTime.ParseExact("30.04.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture), 
                    DueDate = DateTime.ParseExact("10.06.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    IdPatient = 3,
                    IdDoctor = 2
                },
                new Prescription
                {
                    IdPrescription = 8, Date = DateTime.ParseExact("18.04.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture), 
                    DueDate = DateTime.ParseExact("04.07.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    IdPatient = 4,
                    IdDoctor = 1
                },
                new Prescription
                {
                    IdPrescription = 10, Date = DateTime.ParseExact("06.05.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture), 
                    DueDate = DateTime.ParseExact("12.07.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    IdPatient = 4,
                    IdDoctor = 4
                },
                new Prescription
                {
                    IdPrescription = 11, Date = DateTime.ParseExact("16.05.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture), 
                    DueDate = DateTime.ParseExact("20.07.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    IdPatient = 4,
                    IdDoctor = 4
                }
            };

        }

        private static IEnumerable<Medicament> GenerateMedicaments()
        {
            return new List<Medicament>
            {
                new Medicament()
                {
                    IdMedicament = 1, 
                    Name = "med_1", 
                    Description = "desc_1", 
                    Type = "type_1"
                },
                new Medicament()
                {
                    IdMedicament = 2, 
                    Name = "med_2", 
                    Description = "desc_2", 
                    Type = "type_2"
                },
                new Medicament()
                {
                    IdMedicament = 3, 
                    Name = "med_3", 
                    Description = "desc_3", 
                    Type = "type_3"
                },
                new Medicament()
                {
                    IdMedicament = 4, 
                    Name = "med_4", 
                    Description = "desc_4", 
                    Type = "type_4"
                },
                new Medicament()
                {
                    IdMedicament = 5, 
                    Name = "med_5", 
                    Description = "desc_5", 
                    Type = "type_5"
                },
                new Medicament()
                {
                    IdMedicament = 6, 
                    Name = "med_6", 
                    Description = "desc_6", 
                    Type = "type_6"
                }
            };
        }

        private static IEnumerable<Patient> GeneratePatients()
        {
            return new List<Patient>
            {
                new Patient()
                {
                    IdPatient = 1, 
                    FirstName = "Jan", 
                    LastName = "Kowalczyk", 
                    BirthDate = DateTime.ParseExact("22.04.1980", "dd.MM.yyyy", CultureInfo.InvariantCulture)
                },
                new Patient()
                {
                    IdPatient = 2, 
                    FirstName = "Anna", 
                    LastName = "Power", 
                    BirthDate = DateTime.ParseExact("02.12.1986", "dd.MM.yyyy", CultureInfo.InvariantCulture)
                },
                new Patient()
                {
                    IdPatient = 3, 
                    FirstName = "Saxon", 
                    LastName = "Beattie", 
                    BirthDate = DateTime.ParseExact("10.08.1930", "dd.MM.yyyy", CultureInfo.InvariantCulture)
                },
                new Patient()
                {
                    IdPatient = 4, 
                    FirstName = "Gia", 
                    LastName = "Forrest", 
                    BirthDate = DateTime.ParseExact("03.07.1992", "dd.MM.yyyy", CultureInfo.InvariantCulture)
                }
            };
        }

        private static IEnumerable<Doctor> GenerateDoctors()
        {
            return new List<Doctor>
            {
                new Doctor
                {
                    IdDoctor = 1, 
                    FirstName = "Jimmy", 
                    LastName = "Frey", 
                    Email = "Frey@fray.com"
                },
                new Doctor
                {
                    IdDoctor = 2, 
                    FirstName = "Erin", 
                    LastName = "ONeill", 
                    Email = "ONeill@oneil.com"
                },
                new Doctor()
                {
                    IdDoctor = 3, 
                    FirstName = "Bobbie", 
                    LastName = "Clements", 
                    Email = "Clements@clements.com"
                },
                new Doctor()
                {
                    IdDoctor = 4, 
                    FirstName = "Elena", 
                    LastName = "Britton", 
                    Email = "Britton@britton.com"
                }
            };
        }
    }
}