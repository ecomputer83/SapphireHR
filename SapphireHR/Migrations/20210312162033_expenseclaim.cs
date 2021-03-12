using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class expenseclaim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseClaims_Employees_ApprovalEmployeeId",
                table: "ExpenseClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseClaims_Employees_AssigneeEmployeeId",
                table: "ExpenseClaims");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseClaims_ApprovalEmployeeId",
                table: "ExpenseClaims");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseClaims_AssigneeEmployeeId",
                table: "ExpenseClaims");

            migrationBuilder.DropColumn(
                name: "ApprovalEmployeeId",
                table: "ExpenseClaims");

            migrationBuilder.DropColumn(
                name: "AssigneeEmployeeId",
                table: "ExpenseClaims");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Date",
                table: "ExpenseClaims",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ApprovalDate",
                table: "ExpenseClaims",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseClaims_Assignee",
                table: "ExpenseClaims",
                column: "Assignee");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseClaims_Employees_Assignee",
                table: "ExpenseClaims",
                column: "Assignee",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseClaims_Employees_Assignee",
                table: "ExpenseClaims");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseClaims_Assignee",
                table: "ExpenseClaims");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Date",
                table: "ExpenseClaims",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ApprovalDate",
                table: "ExpenseClaims",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApprovalEmployeeId",
                table: "ExpenseClaims",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssigneeEmployeeId",
                table: "ExpenseClaims",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseClaims_ApprovalEmployeeId",
                table: "ExpenseClaims",
                column: "ApprovalEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseClaims_AssigneeEmployeeId",
                table: "ExpenseClaims",
                column: "AssigneeEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseClaims_Employees_ApprovalEmployeeId",
                table: "ExpenseClaims",
                column: "ApprovalEmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseClaims_Employees_AssigneeEmployeeId",
                table: "ExpenseClaims",
                column: "AssigneeEmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
