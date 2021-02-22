using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class modifiedleave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PunchIn",
                table: "EmployeeTimetables");

            migrationBuilder.RenameColumn(
                name: "PunchOut",
                table: "EmployeeTimetables",
                newName: "Time");

            migrationBuilder.AddColumn<bool>(
                name: "Punch",
                table: "EmployeeTimetables",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "LeaveTypeId",
                table: "EmployeeLeaves",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaves_LeaveTypeId",
                table: "EmployeeLeaves",
                column: "LeaveTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeLeaves_LeaveTypes_LeaveTypeId",
                table: "EmployeeLeaves",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeLeaves_LeaveTypes_LeaveTypeId",
                table: "EmployeeLeaves");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeLeaves_LeaveTypeId",
                table: "EmployeeLeaves");

            migrationBuilder.DropColumn(
                name: "Punch",
                table: "EmployeeTimetables");

            migrationBuilder.DropColumn(
                name: "LeaveTypeId",
                table: "EmployeeLeaves");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "EmployeeTimetables",
                newName: "PunchOut");

            migrationBuilder.AddColumn<string>(
                name: "PunchIn",
                table: "EmployeeTimetables",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
