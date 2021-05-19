using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class Queries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HRManager",
                table: "DisciplinaryMeasures");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "LeavePolicies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QueryId",
                table: "DisciplinaryMeasures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ExitInterview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResignationId = table.Column<int>(type: "int", nullable: false),
                    InterviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExitInterview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExitInterview_EmployeeResignations_ResignationId",
                        column: x => x.ResignationId,
                        principalTable: "EmployeeResignations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Queries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Accusation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponseBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QueryType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Queries_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeavePolicies_CompanyId",
                table: "LeavePolicies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ExitInterview_ResignationId",
                table: "ExitInterview",
                column: "ResignationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Queries_EmployeeId",
                table: "Queries",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeavePolicies_CompanyInfos_CompanyId",
                table: "LeavePolicies",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeavePolicies_CompanyInfos_CompanyId",
                table: "LeavePolicies");

            migrationBuilder.DropTable(
                name: "ExitInterview");

            migrationBuilder.DropTable(
                name: "Queries");

            migrationBuilder.DropIndex(
                name: "IX_LeavePolicies_CompanyId",
                table: "LeavePolicies");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "LeavePolicies");

            migrationBuilder.DropColumn(
                name: "QueryId",
                table: "DisciplinaryMeasures");

            migrationBuilder.AddColumn<string>(
                name: "HRManager",
                table: "DisciplinaryMeasures",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
