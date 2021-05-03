using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class modifiedTimetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TaxPayments_SalaryId",
                table: "TaxPayments");

            migrationBuilder.DropIndex(
                name: "IX_SalaryPayments_SalaryId",
                table: "SalaryPayments");

            migrationBuilder.DropIndex(
                name: "IX_PensionPayments_SalaryId",
                table: "PensionPayments");

            migrationBuilder.DropColumn(
                name: "Punch",
                table: "EmployeeTimetables");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "EmployeeTimetables",
                newName: "PunchOutTime");

            migrationBuilder.AddColumn<string>(
                name: "PunchInTime",
                table: "EmployeeTimetables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 569, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 569, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 569, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 569, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 569, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 569, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 569, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 569, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 569, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 569, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 569, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 569, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 569, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 569, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 569, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 569, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 569, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 569, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 569, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 565, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 567, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 2, 16, 32, 58, 567, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.CreateIndex(
                name: "IX_TaxPayments_SalaryId",
                table: "TaxPayments",
                column: "SalaryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalaryPayments_SalaryId",
                table: "SalaryPayments",
                column: "SalaryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PensionPayments_SalaryId",
                table: "PensionPayments",
                column: "SalaryId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TaxPayments_SalaryId",
                table: "TaxPayments");

            migrationBuilder.DropIndex(
                name: "IX_SalaryPayments_SalaryId",
                table: "SalaryPayments");

            migrationBuilder.DropIndex(
                name: "IX_PensionPayments_SalaryId",
                table: "PensionPayments");

            migrationBuilder.DropColumn(
                name: "PunchInTime",
                table: "EmployeeTimetables");

            migrationBuilder.RenameColumn(
                name: "PunchOutTime",
                table: "EmployeeTimetables",
                newName: "Time");

            migrationBuilder.AddColumn<bool>(
                name: "Punch",
                table: "EmployeeTimetables",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 966, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 966, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 966, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 966, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 966, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 966, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 966, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 966, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 966, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 966, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 966, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 966, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 966, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 966, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 966, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 966, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 966, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 966, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 967, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 962, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 965, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 29, 16, 50, 42, 965, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.CreateIndex(
                name: "IX_TaxPayments_SalaryId",
                table: "TaxPayments",
                column: "SalaryId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryPayments_SalaryId",
                table: "SalaryPayments",
                column: "SalaryId");

            migrationBuilder.CreateIndex(
                name: "IX_PensionPayments_SalaryId",
                table: "PensionPayments",
                column: "SalaryId");
        }
    }
}
