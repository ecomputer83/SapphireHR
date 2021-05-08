using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class addPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2021, 5, 8, 12, 19, 3, 208, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 208, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 208, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 208, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 208, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 208, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 208, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 208, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 208, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 208, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 208, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 208, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 208, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 208, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 208, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 208, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 208, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 208, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 208, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 204, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 206, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 8, 12, 19, 3, 206, DateTimeKind.Local).AddTicks(9324));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
