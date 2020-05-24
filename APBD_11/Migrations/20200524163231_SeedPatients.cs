using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_11.Migrations
{
    public partial class SeedPatients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "apbd_doctor",
                table: "Patient",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jan", "Kowalczyk" },
                    { 2, new DateTime(1986, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna", "Power" },
                    { 3, new DateTime(1930, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saxon", "Beattie" },
                    { 4, new DateTime(1992, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gia", "Forrest" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 4);
        }
    }
}
