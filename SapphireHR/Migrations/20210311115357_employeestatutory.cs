using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class employeestatutory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EmployeePensions_EmployeeId",
                table: "EmployeePensions");

            migrationBuilder.CreateTable(
                name: "EmployeeStatutories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    SalaryBasis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalaryAmount = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeStatutories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeStatutories_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePensions_EmployeeId",
                table: "EmployeePensions",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeStatutories_EmployeeId",
                table: "EmployeeStatutories",
                column: "EmployeeId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeStatutories");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePensions_EmployeeId",
                table: "EmployeePensions");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePensions_EmployeeId",
                table: "EmployeePensions",
                column: "EmployeeId");
        }
    }
}
