using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class MappedVirtualLeave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LeaveSettingId",
                table: "LeavePolicies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeavePolicies_LeaveSettingId",
                table: "LeavePolicies",
                column: "LeaveSettingId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeavePolicies_LeaveSettings_LeaveSettingId",
                table: "LeavePolicies",
                column: "LeaveSettingId",
                principalTable: "LeaveSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeavePolicies_LeaveSettings_LeaveSettingId",
                table: "LeavePolicies");

            migrationBuilder.DropIndex(
                name: "IX_LeavePolicies_LeaveSettingId",
                table: "LeavePolicies");

            migrationBuilder.DropColumn(
                name: "LeaveSettingId",
                table: "LeavePolicies");
        }
    }
}
