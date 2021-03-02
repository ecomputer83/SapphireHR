using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class removevacancies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Vacancies_VacancyId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobRequisitions_Vacancies_VacancyId",
                table: "JobRequisitions");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Designations_DesignationId",
                table: "Vacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Employees_RequestBy",
                table: "Vacancies");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_JobProfiles_DesignationId",
                table: "Vacancies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vacancies",
                table: "Vacancies");

            migrationBuilder.RenameTable(
                name: "Vacancies",
                newName: "Vacancy");

            migrationBuilder.RenameIndex(
                name: "IX_Vacancies_RequestBy",
                table: "Vacancy",
                newName: "IX_Vacancy_RequestBy");

            migrationBuilder.RenameIndex(
                name: "IX_Vacancies_DesignationId",
                table: "Vacancy",
                newName: "IX_Vacancy_DesignationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vacancy",
                table: "Vacancy",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Vacancy_VacancyId",
                table: "Applications",
                column: "VacancyId",
                principalTable: "Vacancy",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_JobRequisitions_Vacancy_VacancyId",
                table: "JobRequisitions",
                column: "VacancyId",
                principalTable: "Vacancy",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancy_Designations_DesignationId",
                table: "Vacancy",
                column: "DesignationId",
                principalTable: "Designations",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancy_Employees_RequestBy",
                table: "Vacancy",
                column: "RequestBy",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancy_JobProfiles_DesignationId",
                table: "Vacancy",
                column: "DesignationId",
                principalTable: "JobProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Vacancy_VacancyId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobRequisitions_Vacancy_VacancyId",
                table: "JobRequisitions");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancy_Designations_DesignationId",
                table: "Vacancy");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancy_Employees_RequestBy",
                table: "Vacancy");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancy_JobProfiles_DesignationId",
                table: "Vacancy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vacancy",
                table: "Vacancy");

            migrationBuilder.RenameTable(
                name: "Vacancy",
                newName: "Vacancies");

            migrationBuilder.RenameIndex(
                name: "IX_Vacancy_RequestBy",
                table: "Vacancies",
                newName: "IX_Vacancies_RequestBy");

            migrationBuilder.RenameIndex(
                name: "IX_Vacancy_DesignationId",
                table: "Vacancies",
                newName: "IX_Vacancies_DesignationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vacancies",
                table: "Vacancies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Vacancies_VacancyId",
                table: "Applications",
                column: "VacancyId",
                principalTable: "Vacancies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobRequisitions_Vacancies_VacancyId",
                table: "JobRequisitions",
                column: "VacancyId",
                principalTable: "Vacancies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Designations_DesignationId",
                table: "Vacancies",
                column: "DesignationId",
                principalTable: "Designations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Employees_RequestBy",
                table: "Vacancies",
                column: "RequestBy",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_JobProfiles_DesignationId",
                table: "Vacancies",
                column: "DesignationId",
                principalTable: "JobProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
