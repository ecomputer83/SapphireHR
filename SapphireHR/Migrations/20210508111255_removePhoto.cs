using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class removePhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassportPhoto",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 389, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 389, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 389, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 389, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 389, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 389, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 389, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 389, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 389, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 389, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 389, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 389, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 389, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 389, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 389, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 389, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 389, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 389, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 389, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 384, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 387, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 12, 54, 387, DateTimeKind.Local).AddTicks(5152));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "PassportPhoto",
                table: "Employees",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 80, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 80, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 80, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 80, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 80, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 80, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 80, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 80, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 80, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 80, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 80, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 80, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 80, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 80, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 80, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 80, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 80, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 80, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 80, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 76, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 78, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 5, 51, 78, DateTimeKind.Local).AddTicks(9735));
        }
    }
}
