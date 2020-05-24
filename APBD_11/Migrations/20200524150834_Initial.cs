using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_11.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "apbd_doctor");

            migrationBuilder.CreateTable(
                name: "Doctor",
                schema: "apbd_doctor",
                columns: table => new
                {
                    IdDoctor = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Enrollment_pk", x => x.IdDoctor);
                });

            migrationBuilder.CreateTable(
                name: "Medicament",
                schema: "apbd_doctor",
                columns: table => new
                {
                    IdMedicament = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Medicament_pk", x => x.IdMedicament);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                schema: "apbd_doctor",
                columns: table => new
                {
                    IdPatient = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Patient_pk", x => x.IdPatient);
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                schema: "apbd_doctor",
                columns: table => new
                {
                    IdPrescription = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    DueDate = table.Column<DateTime>(type: "date", nullable: false),
                    IdPatient = table.Column<int>(type: "int", nullable: false),
                    IdDoctor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Prescription_pk", x => x.IdPrescription);
                    table.ForeignKey(
                        name: "Doctor_Prescription",
                        column: x => x.IdDoctor,
                        principalSchema: "apbd_doctor",
                        principalTable: "Doctor",
                        principalColumn: "IdDoctor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "Patient_Prescription",
                        column: x => x.IdPatient,
                        principalSchema: "apbd_doctor",
                        principalTable: "Patient",
                        principalColumn: "IdPatient",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prescription_Medicament",
                schema: "apbd_doctor",
                columns: table => new
                {
                    IdMedicament = table.Column<int>(type: "int", nullable: false),
                    IdPrescription = table.Column<int>(type: "int", nullable: false),
                    Dose = table.Column<int>(type: "int", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription_Medicament", x => new { x.IdMedicament, x.IdPrescription });
                    table.ForeignKey(
                        name: "Medicament_Prescription_Medicament",
                        column: x => x.IdMedicament,
                        principalSchema: "apbd_doctor",
                        principalTable: "Medicament",
                        principalColumn: "IdMedicament",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "Prescription_Prescription_Medicament",
                        column: x => x.IdPrescription,
                        principalSchema: "apbd_doctor",
                        principalTable: "Prescription",
                        principalColumn: "IdPrescription",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_IdDoctor",
                schema: "apbd_doctor",
                table: "Prescription",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_IdPatient",
                schema: "apbd_doctor",
                table: "Prescription",
                column: "IdPatient");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_Medicament_IdPrescription",
                schema: "apbd_doctor",
                table: "Prescription_Medicament",
                column: "IdPrescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prescription_Medicament",
                schema: "apbd_doctor");

            migrationBuilder.DropTable(
                name: "Medicament",
                schema: "apbd_doctor");

            migrationBuilder.DropTable(
                name: "Prescription",
                schema: "apbd_doctor");

            migrationBuilder.DropTable(
                name: "Doctor",
                schema: "apbd_doctor");

            migrationBuilder.DropTable(
                name: "Patient",
                schema: "apbd_doctor");
        }
    }
}
