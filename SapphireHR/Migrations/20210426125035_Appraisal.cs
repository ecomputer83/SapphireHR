using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class Appraisal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeePerfomanceAppraisals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignationPerformanceId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Tech_CE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tech_Marketing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tech_Management = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tech_Administration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tech_Presentation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tech_QOW = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tech_Efficiency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Org_Integrity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Org_Professionalism = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Org_Teamwork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Org_CriticalThinking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Org_Conflict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Org_Attendance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Org_ATMD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppraisalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePerfomanceAppraisals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeePerfomanceAppraisals_DesignationPerformances_DesignationPerformanceId",
                        column: x => x.DesignationPerformanceId,
                        principalTable: "DesignationPerformances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EmployeePerfomanceAppraisals_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    BankAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationAccounts_OrganizationInfos_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "OrganizationInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    SalaryPaymentByOrg = table.Column<bool>(type: "bit", nullable: false),
                    SalaryStartDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationSettings_OrganizationInfos_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "OrganizationInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SalaryBatchPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrincipalId = table.Column<int>(type: "int", nullable: false),
                    PrincipaTypelId = table.Column<int>(type: "int", nullable: false),
                    BatchRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalAmount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceBankCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalBankCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryBatchPayments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalaryPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalaryBatchPaymentId = table.Column<int>(type: "int", nullable: false),
                    TransactionRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationNarration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalaryPayments_SalaryBatchPayments_SalaryBatchPaymentId",
                        column: x => x.SalaryBatchPaymentId,
                        principalTable: "SalaryBatchPayments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 26, 13, 50, 31, 171, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 26, 13, 50, 31, 179, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 26, 13, 50, 31, 179, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePerfomanceAppraisals_DesignationPerformanceId",
                table: "EmployeePerfomanceAppraisals",
                column: "DesignationPerformanceId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePerfomanceAppraisals_EmployeeId",
                table: "EmployeePerfomanceAppraisals",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationAccounts_OrganizationId",
                table: "OrganizationAccounts",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationSettings_OrganizationId",
                table: "OrganizationSettings",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryPayments_SalaryBatchPaymentId",
                table: "SalaryPayments",
                column: "SalaryBatchPaymentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeePerfomanceAppraisals");

            migrationBuilder.DropTable(
                name: "OrganizationAccounts");

            migrationBuilder.DropTable(
                name: "OrganizationSettings");

            migrationBuilder.DropTable(
                name: "SalaryPayments");

            migrationBuilder.DropTable(
                name: "SalaryBatchPayments");

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 23, 15, 17, 10, 262, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 23, 15, 17, 10, 266, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 4, 23, 15, 17, 10, 266, DateTimeKind.Local).AddTicks(590));
        }
    }
}
