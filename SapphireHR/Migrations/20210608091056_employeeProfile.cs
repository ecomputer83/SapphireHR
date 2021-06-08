using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class employeeProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmploymentOfSpouse",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NationalIdentityNumber",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NoOfChildren",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PassportExpiryDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "BvnNumber",
                table: "EmployeeBank",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmploymentOfSpouse",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "NationalIdentityNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "NoOfChildren",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PassportExpiryDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "BvnNumber",
                table: "EmployeeBank");
        }
    }
}
