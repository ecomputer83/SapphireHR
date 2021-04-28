using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class companyabbrv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Abbrv",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 763, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 763, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 763, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 763, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 763, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 763, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 763, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 763, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 763, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 763, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 763, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 763, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 763, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 763, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 763, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 763, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 763, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 763, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 763, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 759, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 761, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 14, 8, 8, 761, DateTimeKind.Local).AddTicks(8725));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Abbrv",
                table: "CompanyInfos");

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 117, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 119, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 28, 1, 19, 15, 119, DateTimeKind.Local).AddTicks(7629));
        }
    }
}
