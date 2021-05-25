using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class modifiedapplicantmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applicants_OrganizationInfos_OrganizationId",
                table: "Applicants");

            migrationBuilder.RenameColumn(
                name: "OrganizationId",
                table: "Applicants",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Applicants_OrganizationId",
                table: "Applicants",
                newName: "IX_Applicants_CompanyId");

            migrationBuilder.AddColumn<string>(
                name: "Reference",
                table: "EmployeeSalaries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Applicants_CompanyInfos_CompanyId",
                table: "Applicants",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applicants_CompanyInfos_CompanyId",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "Reference",
                table: "EmployeeSalaries");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Applicants",
                newName: "OrganizationId");

            migrationBuilder.RenameIndex(
                name: "IX_Applicants_CompanyId",
                table: "Applicants",
                newName: "IX_Applicants_OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applicants_OrganizationInfos_OrganizationId",
                table: "Applicants",
                column: "OrganizationId",
                principalTable: "OrganizationInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
