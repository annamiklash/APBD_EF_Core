using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_11.Migrations
{
    public partial class SeedMedicaments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "apbd_doctor",
                table: "Medicament",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "desc_1", "med_1", "type_1" },
                    { 2, "desc_2", "med_2", "type_2" },
                    { 3, "desc_3", "med_3", "type_3" },
                    { 4, "desc_4", "med_4", "type_4" },
                    { 5, "desc_5", "med_5", "type_5" },
                    { 6, "desc_6", "med_6", "type_6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "apbd_doctor",
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 6);
        }
    }
}
