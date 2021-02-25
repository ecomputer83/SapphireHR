using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class modifiedvacancy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobRequisitions_JobProfiles_JobProfileId",
                table: "JobRequisitions");

            migrationBuilder.RenameColumn(
                name: "JobProfileId",
                table: "JobRequisitions",
                newName: "VacancyId");

            migrationBuilder.RenameIndex(
                name: "IX_JobRequisitions_JobProfileId",
                table: "JobRequisitions",
                newName: "IX_JobRequisitions_VacancyId");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Vacancies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PeriodFrom",
                table: "Vacancies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PeriodTo",
                table: "Vacancies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "RequestBy",
                table: "Vacancies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RequestedBy",
                table: "Vacancies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "RequestedOn",
                table: "Vacancies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_RequestBy",
                table: "Vacancies",
                column: "RequestBy");

            migrationBuilder.AddForeignKey(
                name: "FK_JobRequisitions_Vacancies_VacancyId",
                table: "JobRequisitions",
                column: "VacancyId",
                principalTable: "Vacancies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_Employees_RequestBy",
                table: "Vacancies",
                column: "RequestBy",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobRequisitions_Vacancies_VacancyId",
                table: "JobRequisitions");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_Employees_RequestBy",
                table: "Vacancies");

            migrationBuilder.DropIndex(
                name: "IX_Vacancies_RequestBy",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "PeriodFrom",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "PeriodTo",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "RequestBy",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "RequestedBy",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "RequestedOn",
                table: "Vacancies");

            migrationBuilder.RenameColumn(
                name: "VacancyId",
                table: "JobRequisitions",
                newName: "JobProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_JobRequisitions_VacancyId",
                table: "JobRequisitions",
                newName: "IX_JobRequisitions_JobProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobRequisitions_JobProfiles_JobProfileId",
                table: "JobRequisitions",
                column: "JobProfileId",
                principalTable: "JobProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
