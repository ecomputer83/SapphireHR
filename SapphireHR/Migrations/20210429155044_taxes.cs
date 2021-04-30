using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class taxes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrincipaTypelId",
                table: "SalaryBatchPayments");

            migrationBuilder.RenameColumn(
                name: "Narration",
                table: "SalaryPayments",
                newName: "DestinationBankCode");

            migrationBuilder.RenameColumn(
                name: "PrincipalId",
                table: "SalaryBatchPayments",
                newName: "CompanyId");

            migrationBuilder.AddColumn<int>(
                name: "SalaryId",
                table: "SalaryPayments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RemitaSecret",
                table: "CompanyAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmployeeTaxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Tin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxOffice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTaxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeTaxes_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PensionBatchPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    BatchRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalAmount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceBankCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PensionBatchPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PensionBatchPayments_CompanyInfos_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "CompanyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TaxBatchPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    BatchRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalAmount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceBankCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxBatchPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxBatchPayments_CompanyInfos_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "CompanyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PensionPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PensionBatchPaymentId = table.Column<int>(type: "int", nullable: false),
                    SalaryId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    EmployeeContribution = table.Column<double>(type: "float", nullable: false),
                    EmployerContribution = table.Column<double>(type: "float", nullable: false),
                    VoluntryContribution = table.Column<double>(type: "float", nullable: false),
                    TransactionRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiarySurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryOtherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PfaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PfaPin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionMonth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Period = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PensionPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PensionPayments_EmployeeSalaries_SalaryId",
                        column: x => x.SalaryId,
                        principalTable: "EmployeeSalaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PensionPayments_PensionBatchPayments_PensionBatchPaymentId",
                        column: x => x.PensionBatchPaymentId,
                        principalTable: "PensionBatchPayments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TaxPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxBatchPaymentId = table.Column<int>(type: "int", nullable: false),
                    SalaryId = table.Column<int>(type: "int", nullable: false),
                    TaxAmount = table.Column<double>(type: "float", nullable: false),
                    TransactionRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionMonth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Period = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaxPayments_EmployeeSalaries_SalaryId",
                        column: x => x.SalaryId,
                        principalTable: "EmployeeSalaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TaxPayments_TaxBatchPayments_TaxBatchPaymentId",
                        column: x => x.TaxBatchPaymentId,
                        principalTable: "TaxBatchPayments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

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
                name: "IX_SalaryPayments_SalaryId",
                table: "SalaryPayments",
                column: "SalaryId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryBatchPayments_CompanyId",
                table: "SalaryBatchPayments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTaxes_EmployeeId",
                table: "EmployeeTaxes",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PensionBatchPayments_CompanyId",
                table: "PensionBatchPayments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PensionPayments_PensionBatchPaymentId",
                table: "PensionPayments",
                column: "PensionBatchPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_PensionPayments_SalaryId",
                table: "PensionPayments",
                column: "SalaryId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxBatchPayments_CompanyId",
                table: "TaxBatchPayments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxPayments_SalaryId",
                table: "TaxPayments",
                column: "SalaryId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxPayments_TaxBatchPaymentId",
                table: "TaxPayments",
                column: "TaxBatchPaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryBatchPayments_CompanyInfos_CompanyId",
                table: "SalaryBatchPayments",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryPayments_EmployeeSalaries_SalaryId",
                table: "SalaryPayments",
                column: "SalaryId",
                principalTable: "EmployeeSalaries",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalaryBatchPayments_CompanyInfos_CompanyId",
                table: "SalaryBatchPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_SalaryPayments_EmployeeSalaries_SalaryId",
                table: "SalaryPayments");

            migrationBuilder.DropTable(
                name: "EmployeeTaxes");

            migrationBuilder.DropTable(
                name: "PensionPayments");

            migrationBuilder.DropTable(
                name: "TaxPayments");

            migrationBuilder.DropTable(
                name: "PensionBatchPayments");

            migrationBuilder.DropTable(
                name: "TaxBatchPayments");

            migrationBuilder.DropIndex(
                name: "IX_SalaryPayments_SalaryId",
                table: "SalaryPayments");

            migrationBuilder.DropIndex(
                name: "IX_SalaryBatchPayments_CompanyId",
                table: "SalaryBatchPayments");

            migrationBuilder.DropColumn(
                name: "SalaryId",
                table: "SalaryPayments");

            migrationBuilder.DropColumn(
                name: "RemitaSecret",
                table: "CompanyAccounts");

            migrationBuilder.RenameColumn(
                name: "DestinationBankCode",
                table: "SalaryPayments",
                newName: "Narration");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "SalaryBatchPayments",
                newName: "PrincipalId");

            migrationBuilder.AddColumn<int>(
                name: "PrincipaTypelId",
                table: "SalaryBatchPayments",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
