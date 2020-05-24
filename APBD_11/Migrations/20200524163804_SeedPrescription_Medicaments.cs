using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_11.Migrations
{
    public partial class SeedPrescription_Medicaments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "apbd_doctor",
                table: "Prescription_Medicament",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[,]
                {
                    { 1, 1, "details 1", 30 },
                    { 1, 2, "details 2", 15 },
                    { 2, 3, "details 3", 100 },
                    { 3, 4, "details 4", 20 },
                    { 5, 6, "details 5", 10 },
                    { 6, 7, "details 6", 5 },
                    { 6, 8, "details 7", 14 },
                    { 6, 3, "details 8", 100 },
                    { 3, 10, "details 9", 8 },
                    { 3, 5, "details 10", 10 },
                    { 4, 2, "details 11", 21 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 6, 9 });
        }
    }
}
