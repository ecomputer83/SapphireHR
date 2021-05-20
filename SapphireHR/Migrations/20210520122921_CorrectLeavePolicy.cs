using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class CorrectLeavePolicy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeavePolicies_CompanyInfos_CompanyId",
                table: "LeavePolicies");

            migrationBuilder.DropForeignKey(
                name: "FK_LeavePolicies_LeaveSettings_LeaveSettingId",
                table: "LeavePolicies");

            migrationBuilder.DropForeignKey(
                name: "FK_LeavePolicies_LeaveTypes_TypeId",
                table: "LeavePolicies");

            migrationBuilder.DropIndex(
                name: "IX_LeavePolicies_CompanyId",
                table: "LeavePolicies");

            migrationBuilder.DropIndex(
                name: "IX_LeavePolicies_LeaveSettingId",
                table: "LeavePolicies");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "LeavePolicies");

            migrationBuilder.DropColumn(
                name: "LeaveSettingId",
                table: "LeavePolicies");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "LeavePolicies",
                newName: "SettingId");

            migrationBuilder.RenameIndex(
                name: "IX_LeavePolicies_TypeId",
                table: "LeavePolicies",
                newName: "IX_LeavePolicies_SettingId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeavePolicies_LeaveSettings_SettingId",
                table: "LeavePolicies",
                column: "SettingId",
                principalTable: "LeaveSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeavePolicies_LeaveSettings_SettingId",
                table: "LeavePolicies");

            migrationBuilder.RenameColumn(
                name: "SettingId",
                table: "LeavePolicies",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_LeavePolicies_SettingId",
                table: "LeavePolicies",
                newName: "IX_LeavePolicies_TypeId");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "LeavePolicies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LeaveSettingId",
                table: "LeavePolicies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeavePolicies_CompanyId",
                table: "LeavePolicies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_LeavePolicies_LeaveSettingId",
                table: "LeavePolicies",
                column: "LeaveSettingId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeavePolicies_CompanyInfos_CompanyId",
                table: "LeavePolicies",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeavePolicies_LeaveSettings_LeaveSettingId",
                table: "LeavePolicies",
                column: "LeaveSettingId",
                principalTable: "LeaveSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeavePolicies_LeaveTypes_TypeId",
                table: "LeavePolicies",
                column: "TypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
