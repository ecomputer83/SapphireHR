using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class modifiedemployeesalary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Others",
                table: "EmployeeSalaries",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Reasons",
                table: "EmployeeSalaries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SalaryDate",
                table: "EmployeeSalaries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Others",
                table: "EmployeeSalaries");

            migrationBuilder.DropColumn(
                name: "Reasons",
                table: "EmployeeSalaries");

            migrationBuilder.DropColumn(
                name: "SalaryDate",
                table: "EmployeeSalaries");
        }
    }
}
