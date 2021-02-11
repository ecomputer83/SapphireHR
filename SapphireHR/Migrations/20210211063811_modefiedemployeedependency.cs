using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class modefiedemployeedependency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "Holidays",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "EmployeeLeaves",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_OrganizationId",
                table: "Holidays",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTransfers_EmployeeId",
                table: "EmployeeTransfers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTimetables_EmployeeId",
                table: "EmployeeTimetables",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePensions_EmployeeId",
                table: "EmployeePensions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaves_EmployeeId",
                table: "EmployeeLeaves",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyLeavePolicies_EmployeeId",
                table: "CompanyLeavePolicies",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyLeavePolicies_PolicyId",
                table: "CompanyLeavePolicies",
                column: "PolicyId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyLeavePolicies_Employees_EmployeeId",
                table: "CompanyLeavePolicies",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyLeavePolicies_LeavePolicies_PolicyId",
                table: "CompanyLeavePolicies",
                column: "PolicyId",
                principalTable: "LeavePolicies",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeLeaves_Employees_EmployeeId",
                table: "EmployeeLeaves",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePensions_Employees_EmployeeId",
                table: "EmployeePensions",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTimetables_Employees_EmployeeId",
                table: "EmployeeTimetables",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTransfers_Employees_EmployeeId",
                table: "EmployeeTransfers",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Holidays_OrganizationInfos_OrganizationId",
                table: "Holidays",
                column: "OrganizationId",
                principalTable: "OrganizationInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyLeavePolicies_Employees_EmployeeId",
                table: "CompanyLeavePolicies");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyLeavePolicies_LeavePolicies_PolicyId",
                table: "CompanyLeavePolicies");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeLeaves_Employees_EmployeeId",
                table: "EmployeeLeaves");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePensions_Employees_EmployeeId",
                table: "EmployeePensions");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTimetables_Employees_EmployeeId",
                table: "EmployeeTimetables");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTransfers_Employees_EmployeeId",
                table: "EmployeeTransfers");

            migrationBuilder.DropForeignKey(
                name: "FK_Holidays_OrganizationInfos_OrganizationId",
                table: "Holidays");

            migrationBuilder.DropIndex(
                name: "IX_Holidays_OrganizationId",
                table: "Holidays");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTransfers_EmployeeId",
                table: "EmployeeTransfers");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTimetables_EmployeeId",
                table: "EmployeeTimetables");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePensions_EmployeeId",
                table: "EmployeePensions");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeLeaves_EmployeeId",
                table: "EmployeeLeaves");

            migrationBuilder.DropIndex(
                name: "IX_CompanyLeavePolicies_EmployeeId",
                table: "CompanyLeavePolicies");

            migrationBuilder.DropIndex(
                name: "IX_CompanyLeavePolicies_PolicyId",
                table: "CompanyLeavePolicies");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmployeeLeaves");
        }
    }
}
