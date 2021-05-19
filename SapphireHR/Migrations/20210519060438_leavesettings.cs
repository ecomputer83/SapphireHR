using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class leavesettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_LeaveSettings_TypeId",
                table: "LeaveSettings",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveSettings_LeaveTypes_TypeId",
                table: "LeaveSettings",
                column: "TypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveSettings_LeaveTypes_TypeId",
                table: "LeaveSettings");

            migrationBuilder.DropIndex(
                name: "IX_LeaveSettings_TypeId",
                table: "LeaveSettings");
        }
    }
}
