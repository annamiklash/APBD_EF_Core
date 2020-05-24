using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_11.Migrations
{
    public partial class SeedPrescriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "apbd_doctor",
                table: "Prescription",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, new DateTime(2020, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 3, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 4, new DateTime(2020, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 5, new DateTime(2020, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 6, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 7, new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 8, new DateTime(2020, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 },
                    { 10, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 11, new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 11);
        }
    }
}
