using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class seedlookup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrganizationAccounts");

            migrationBuilder.RenameColumn(
                name: "BankCode",
                table: "CompanyAccounts",
                newName: "RemitaUserAccount");

            migrationBuilder.RenameColumn(
                name: "BankAccount",
                table: "CompanyAccounts",
                newName: "EmployerCodeForPension");

            migrationBuilder.AddColumn<string>(
                name: "BankAccountForPension",
                table: "CompanyAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankAccountForSalary",
                table: "CompanyAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankAccountForTax",
                table: "CompanyAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankCodeForPension",
                table: "CompanyAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankCodeForSalary",
                table: "CompanyAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankCodeForTax",
                table: "CompanyAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "CompanyAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SalaryPayDay",
                table: "CompanyAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Lookups",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "LookupDescription", "LookupGroup", "LookupSort", "LookupType", "LookupValue", "Status", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6202), "SYSTEM", "Access Bank Nigeria Plc", 0, 1, "BANKS", "044", 0, null, null },
                    { 19, new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6849), "SYSTEM", "Zenith Bank International", 0, 1, "BANKS", "057", 0, null, null },
                    { 18, new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6830), "SYSTEM", "WEMA Bank Plc", 0, 1, "BANKS", "035", 0, null, null },
                    { 17, new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6809), "SYSTEM", "Unity Bank Plc", 0, 1, "BANKS", "215", 0, null, null },
                    { 16, new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6791), "SYSTEM", "United Bank for Africa Plc", 0, 1, "BANKS", "033", 0, null, null },
                    { 15, new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6772), "SYSTEM", "Union Bank Nigeria Plc", 0, 1, "BANKS", "032", 0, null, null },
                    { 14, new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6752), "SYSTEM", "Sterling Bank Plc", 0, 1, "BANKS", "232", 0, null, null },
                    { 13, new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6733), "SYSTEM", "Stanbic IBTC Plc", 0, 1, "BANKS", "039", 0, null, null },
                    { 12, new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6713), "SYSTEM", "Mainstreet Bank Plc", 0, 1, "BANKS", "014", 0, null, null },
                    { 11, new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6694), "SYSTEM", "Keystone Bank Ltd", 0, 1, "BANKS", "082", 0, null, null },
                    { 9, new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6652), "SYSTEM", "Heritage Banking Company Ltd", 0, 1, "BANKS", "030", 0, null, null },
                    { 8, new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6633), "SYSTEM", "Guaranty Trust Bank Plc", 0, 1, "BANKS", "058", 0, null, null },
                    { 7, new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6613), "SYSTEM", "First City Monument Bank", 0, 1, "BANKS", "214", 0, null, null },
                    { 6, new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6591), "SYSTEM", "First Bank of Nigeria Plc", 0, 1, "BANKS", "011", 0, null, null },
                    { 5, new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6557), "SYSTEM", "Fidelity Bank Plc", 0, 1, "BANKS", "070", 0, null, null },
                    { 4, new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6534), "SYSTEM", "Enterprise Bank Plc", 0, 1, "BANKS", "084", 0, null, null },
                    { 3, new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6513), "SYSTEM", "Ecobank Nigeria", 0, 3, "BANKS", "050", 0, null, null },
                    { 2, new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6480), "SYSTEM", "Diamond Bank Plc", 0, 2, "BANKS", "063", 0, null, null },
                    { 10, new DateTime(2021, 4, 28, 1, 19, 15, 121, DateTimeKind.Local).AddTicks(6674), "SYSTEM", "Jaiz Bank", 0, 1, "BANKS", "301", 0, null, null }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DropColumn(
                name: "BankAccountForPension",
                table: "CompanyAccounts");

            migrationBuilder.DropColumn(
                name: "BankAccountForSalary",
                table: "CompanyAccounts");

            migrationBuilder.DropColumn(
                name: "BankAccountForTax",
                table: "CompanyAccounts");

            migrationBuilder.DropColumn(
                name: "BankCodeForPension",
                table: "CompanyAccounts");

            migrationBuilder.DropColumn(
                name: "BankCodeForSalary",
                table: "CompanyAccounts");

            migrationBuilder.DropColumn(
                name: "BankCodeForTax",
                table: "CompanyAccounts");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "CompanyAccounts");

            migrationBuilder.DropColumn(
                name: "SalaryPayDay",
                table: "CompanyAccounts");

            migrationBuilder.RenameColumn(
                name: "RemitaUserAccount",
                table: "CompanyAccounts",
                newName: "BankCode");

            migrationBuilder.RenameColumn(
                name: "EmployerCodeForPension",
                table: "CompanyAccounts",
                newName: "BankAccount");

            migrationBuilder.CreateTable(
                name: "OrganizationAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationAccounts_OrganizationInfos_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "OrganizationInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 26, 14, 47, 31, 424, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 26, 14, 47, 31, 436, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 26, 14, 47, 31, 436, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationAccounts_OrganizationId",
                table: "OrganizationAccounts",
                column: "OrganizationId");
        }
    }
}
