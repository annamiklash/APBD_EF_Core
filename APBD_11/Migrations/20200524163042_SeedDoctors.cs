using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_11.Migrations
{
    public partial class SeedDoctors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "apbd_doctor",
                table: "Doctor",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Frey@fray.com", "Jimmy", "Frey" },
                    { 2, "ONeill@oneil.com", "Erin", "ONeill" },
                    { 3, "Clements@clements.com", "Bobbie", "Clements" },
                    { 4, "Britton@britton.com", "Elena", "Britton" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 4);
        }
    }
}
