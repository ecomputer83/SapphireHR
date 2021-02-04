using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Database.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
