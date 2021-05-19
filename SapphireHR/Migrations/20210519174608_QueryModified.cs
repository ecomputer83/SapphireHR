using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class QueryModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DisciplinaryMeasures_Employees_EmployeeId",
                table: "DisciplinaryMeasures");

            migrationBuilder.DropIndex(
                name: "IX_DisciplinaryMeasures_EmployeeId",
                table: "DisciplinaryMeasures");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "DisciplinaryMeasures");

            migrationBuilder.DropColumn(
                name: "Form",
                table: "DisciplinaryMeasures");

            migrationBuilder.AddColumn<string>(
                name: "Form",
                table: "Queries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DisciplinaryMeasures_QueryId",
                table: "DisciplinaryMeasures",
                column: "QueryId");

            migrationBuilder.AddForeignKey(
                name: "FK_DisciplinaryMeasures_Queries_QueryId",
                table: "DisciplinaryMeasures",
                column: "QueryId",
                principalTable: "Queries",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DisciplinaryMeasures_Queries_QueryId",
                table: "DisciplinaryMeasures");

            migrationBuilder.DropIndex(
                name: "IX_DisciplinaryMeasures_QueryId",
                table: "DisciplinaryMeasures");

            migrationBuilder.DropColumn(
                name: "Form",
                table: "Queries");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "DisciplinaryMeasures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Form",
                table: "DisciplinaryMeasures",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DisciplinaryMeasures_EmployeeId",
                table: "DisciplinaryMeasures",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DisciplinaryMeasures_Employees_EmployeeId",
                table: "DisciplinaryMeasures",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
