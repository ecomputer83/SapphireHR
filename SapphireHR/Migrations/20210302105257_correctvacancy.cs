using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class correctvacancy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_JobProfiles_DesignationId",
                table: "Vacancies");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_JobProfileId",
                table: "Vacancies",
                column: "JobProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacancies_JobProfiles_JobProfileId",
                table: "Vacancies",
                column: "JobProfileId",
                principalTable: "JobProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacancies_JobProfiles_JobProfileId",
                table: "Vacancies");

            migrationBuilder.DropIndex(
                name: "IX_Vacancies_JobProfileId",
                table: "Vacancies");

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
