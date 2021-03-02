using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class modifiedterminationtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "TerminationTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TerminationTypes_OrganizationId",
                table: "TerminationTypes",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_TerminationTypes_OrganizationInfos_OrganizationId",
                table: "TerminationTypes",
                column: "OrganizationId",
                principalTable: "OrganizationInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TerminationTypes_OrganizationInfos_OrganizationId",
                table: "TerminationTypes");

            migrationBuilder.DropIndex(
                name: "IX_TerminationTypes_OrganizationId",
                table: "TerminationTypes");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "TerminationTypes");
        }
    }
}
