using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class modifiedskillgrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "SkillGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SkillGrades_CompanyId",
                table: "SkillGrades",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_SkillGrades_CompanyInfos_CompanyId",
                table: "SkillGrades",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkillGrades_CompanyInfos_CompanyId",
                table: "SkillGrades");

            migrationBuilder.DropIndex(
                name: "IX_SkillGrades_CompanyId",
                table: "SkillGrades");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "SkillGrades");
        }
    }
}
