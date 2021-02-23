using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class modifiedemployeeleave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RankPermissions_RankId",
                table: "RankPermissions");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "EmployeeLeaves",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RankPermissions_RankId",
                table: "RankPermissions",
                column: "RankId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RankPermissions_RankId",
                table: "RankPermissions");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "EmployeeLeaves");

            migrationBuilder.CreateIndex(
                name: "IX_RankPermissions_RankId",
                table: "RankPermissions",
                column: "RankId");
        }
    }
}
