using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class modifiedemployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EmployeeBank_EmployeeId",
                table: "EmployeeBank");

            migrationBuilder.AddColumn<int>(
                name: "RankId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SkillTypes_CompanyId",
                table: "SkillTypes",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CompanyId",
                table: "Skills",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Ranks_OrganizationId",
                table: "Ranks",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RankId",
                table: "Employees",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBank_EmployeeId",
                table: "EmployeeBank",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationSkills_JobSkillLevelId",
                table: "ApplicationSkills",
                column: "JobSkillLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_OrganizationId",
                table: "Applicants",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applicants_OrganizationInfos_OrganizationId",
                table: "Applicants",
                column: "OrganizationId",
                principalTable: "OrganizationInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationSkills_JobSkillLevels_JobSkillLevelId",
                table: "ApplicationSkills",
                column: "JobSkillLevelId",
                principalTable: "JobSkillLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Ranks_RankId",
                table: "Employees",
                column: "RankId",
                principalTable: "Ranks",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Ranks_OrganizationInfos_OrganizationId",
                table: "Ranks",
                column: "OrganizationId",
                principalTable: "OrganizationInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_CompanyInfos_CompanyId",
                table: "Skills",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillTypes_CompanyInfos_CompanyId",
                table: "SkillTypes",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_JobProfiles_DesignationId",
                table: "Vacancies",
                column: "DesignationId",
                principalTable: "JobProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applicants_OrganizationInfos_OrganizationId",
                table: "Applicants");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationSkills_JobSkillLevels_JobSkillLevelId",
                table: "ApplicationSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Ranks_RankId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Ranks_OrganizationInfos_OrganizationId",
                table: "Ranks");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_CompanyInfos_CompanyId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillTypes_CompanyInfos_CompanyId",
                table: "SkillTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_JobProfiles_DesignationId",
                table: "Vacancies");

            migrationBuilder.DropIndex(
                name: "IX_SkillTypes_CompanyId",
                table: "SkillTypes");

            migrationBuilder.DropIndex(
                name: "IX_Skills_CompanyId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Ranks_OrganizationId",
                table: "Ranks");

            migrationBuilder.DropIndex(
                name: "IX_Employees_RankId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeBank_EmployeeId",
                table: "EmployeeBank");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationSkills_JobSkillLevelId",
                table: "ApplicationSkills");

            migrationBuilder.DropIndex(
                name: "IX_Applicants_OrganizationId",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "RankId",
                table: "Employees");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBank_EmployeeId",
                table: "EmployeeBank",
                column: "EmployeeId",
                unique: true);
        }
    }
}
