using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class virtualmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Onboardings_EmployeeId",
                table: "Onboardings");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentPolicies_DepartmentId",
                table: "DepartmentPolicies");

            migrationBuilder.CreateIndex(
                name: "IX_Onboardings_EmployeeId",
                table: "Onboardings",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentPolicies_DepartmentId",
                table: "DepartmentPolicies",
                column: "DepartmentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Onboardings_EmployeeId",
                table: "Onboardings");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentPolicies_DepartmentId",
                table: "DepartmentPolicies");

            migrationBuilder.CreateIndex(
                name: "IX_Onboardings_EmployeeId",
                table: "Onboardings",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentPolicies_DepartmentId",
                table: "DepartmentPolicies",
                column: "DepartmentId");
        }
    }
}
