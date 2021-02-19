using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class modifiedskills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkillGrades_SkillTypes_SkillTypeId",
                table: "SkillGrades");

            migrationBuilder.DropTable(
                name: "EmployeeStatutories");

            migrationBuilder.DropIndex(
                name: "IX_SkillGrades_SkillTypeId",
                table: "SkillGrades");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeBank_EmployeeId",
                table: "EmployeeBank");

            migrationBuilder.DropColumn(
                name: "SkillTypeId",
                table: "SkillGrades");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "SkillGrades",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DesignationPerformances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    DesignationId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignationPerformances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DesignationPerformances_Designations_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "Designations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeResignations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoticeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResignationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeResignations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeResignations_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSalaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Basic = table.Column<double>(type: "float", nullable: false),
                    HRA = table.Column<double>(type: "float", nullable: false),
                    MA = table.Column<double>(type: "float", nullable: false),
                    PF = table.Column<double>(type: "float", nullable: false),
                    Allowance = table.Column<double>(type: "float", nullable: false),
                    LeaveAllowance = table.Column<double>(type: "float", nullable: false),
                    HMO = table.Column<double>(type: "float", nullable: false),
                    Tax = table.Column<double>(type: "float", nullable: false),
                    NetSalary = table.Column<double>(type: "float", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSalaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeSalaries_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTravels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainDestination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeriodFrom = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    PeriodTo = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DepartureTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CashInAdvance = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTravels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeTravels_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Assignee = table.Column<int>(type: "int", nullable: false),
                    Approval = table.Column<int>(type: "int", nullable: false),
                    ApprovalDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ApprovalEmployeeId = table.Column<int>(type: "int", nullable: true),
                    AssigneeEmployeeId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpenseClaims_Employees_ApprovalEmployeeId",
                        column: x => x.ApprovalEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpenseClaims_Employees_AssigneeEmployeeId",
                        column: x => x.AssigneeEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExpensePromotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<int>(type: "int", nullable: false),
                    FromPromotionId = table.Column<int>(type: "int", nullable: true),
                    To = table.Column<int>(type: "int", nullable: false),
                    ToPromotionId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpensePromotions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpensePromotions_Designations_FromPromotionId",
                        column: x => x.FromPromotionId,
                        principalTable: "Designations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpensePromotions_Designations_ToPromotionId",
                        column: x => x.ToPromotionId,
                        principalTable: "Designations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExpensePromotions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TerminationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerminationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpenseClaimId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpenseTypes_ExpenseClaims_ExpenseClaimId",
                        column: x => x.ExpenseClaimId,
                        principalTable: "ExpenseClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTerminations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoticeDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    TerminationTypeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTerminations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeTerminations_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTerminations_TerminationTypes_TerminationTypeId",
                        column: x => x.TerminationTypeId,
                        principalTable: "TerminationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skills_Type",
                table: "Skills",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBank_EmployeeId",
                table: "EmployeeBank",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DesignationPerformances_DesignationId",
                table: "DesignationPerformances",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeResignations_EmployeeId",
                table: "EmployeeResignations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSalaries_EmployeeId",
                table: "EmployeeSalaries",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTerminations_EmployeeId",
                table: "EmployeeTerminations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTerminations_TerminationTypeId",
                table: "EmployeeTerminations",
                column: "TerminationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTravels_EmployeeId",
                table: "EmployeeTravels",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseClaims_ApprovalEmployeeId",
                table: "ExpenseClaims",
                column: "ApprovalEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseClaims_AssigneeEmployeeId",
                table: "ExpenseClaims",
                column: "AssigneeEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpensePromotions_EmployeeId",
                table: "ExpensePromotions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpensePromotions_FromPromotionId",
                table: "ExpensePromotions",
                column: "FromPromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpensePromotions_ToPromotionId",
                table: "ExpensePromotions",
                column: "ToPromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseTypes_ExpenseClaimId",
                table: "ExpenseTypes",
                column: "ExpenseClaimId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_SkillTypes_Type",
                table: "Skills",
                column: "Type",
                principalTable: "SkillTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_SkillTypes_Type",
                table: "Skills");

            migrationBuilder.DropTable(
                name: "DesignationPerformances");

            migrationBuilder.DropTable(
                name: "EmployeeResignations");

            migrationBuilder.DropTable(
                name: "EmployeeSalaries");

            migrationBuilder.DropTable(
                name: "EmployeeTerminations");

            migrationBuilder.DropTable(
                name: "EmployeeTravels");

            migrationBuilder.DropTable(
                name: "ExpensePromotions");

            migrationBuilder.DropTable(
                name: "ExpenseTypes");

            migrationBuilder.DropTable(
                name: "TerminationTypes");

            migrationBuilder.DropTable(
                name: "ExpenseClaims");

            migrationBuilder.DropIndex(
                name: "IX_Skills_Type",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeBank_EmployeeId",
                table: "EmployeeBank");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "SkillGrades");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "SkillTypeId",
                table: "SkillGrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EmployeeStatutories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    SalaryAmount = table.Column<double>(type: "float", nullable: false),
                    SalaryBasis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeStatutories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeStatutories_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkillGrades_SkillTypeId",
                table: "SkillGrades",
                column: "SkillTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBank_EmployeeId",
                table: "EmployeeBank",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeStatutories_EmployeeId",
                table: "EmployeeStatutories",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SkillGrades_SkillTypes_SkillTypeId",
                table: "SkillGrades",
                column: "SkillTypeId",
                principalTable: "SkillTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
