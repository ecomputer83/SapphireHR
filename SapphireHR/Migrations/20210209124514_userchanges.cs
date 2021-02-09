using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class userchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobProfiles_CompanyRanks_RankId",
                table: "JobProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_RankPermissions_CompanyRanks_RankId",
                table: "RankPermissions");

            migrationBuilder.DropTable(
                name: "CompanyRanks");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationScores_ApplicationId",
                table: "ApplicationScores");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationNegotiations_ApplicationId",
                table: "ApplicationNegotiations");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationInterviews_ApplicationId",
                table: "ApplicationInterviews");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationFaceToViews_ApplicationId",
                table: "ApplicationFaceToViews");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Vacancies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Vacancies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "SkillTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "SkillTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "SkillGrades",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "SkillGrades",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "RankPermissions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "RankPermissions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "RankPermissions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "RankPermissions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "RankPermissions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OrganizationInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Directory",
                table: "OrganizationInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "OrganizationInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OrganizationHeaders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "OrganizationHeaders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Onboardings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Onboardings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Lookups",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Lookups",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "LeaveTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "LeaveTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "LeaveTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "LeaveSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "LeaveSettings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "LeaveSettings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "LeavePolicies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "LeavePolicies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "JobSkillLevels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "JobSkillLevels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "JobRequisitions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "JobRequisitions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "JobProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "JobProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "JobProfessions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "JobProfessions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "JobCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "JobCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Holidays",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Holidays",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EmployeeTransfers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "EmployeeTransfers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EmployeeTimetables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "EmployeeTimetables",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EmployeeStatutories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "EmployeeStatutories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EmployeePensions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "EmployeePensions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EmployeeLeaves",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "EmployeeLeaves",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EmployeeFamilies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "EmployeeFamilies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EmployeeExperiences",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "EmployeeExperiences",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EmployeeEmergencies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "EmployeeEmergencies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EmployeeEducations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "EmployeeEducations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EmployeeBank",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "EmployeeBank",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Designations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Designations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CompanyLeavePolicies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "CompanyLeavePolicies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Directory",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "CompanyInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CompanyEmployees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "CompanyEmployees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ApplicationSkills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ApplicationSkills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ApplicationScores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ApplicationScores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ApplicationNegotiations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ApplicationNegotiations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ApplicationInterviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ApplicationInterviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ApplicationFaceToViews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ApplicationFaceToViews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userType = table.Column<int>(type: "int", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_OrganizationInfos_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "OrganizationInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    RankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveTypes_OrganizationId",
                table: "LeaveTypes",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveSettings_CompanyId",
                table: "LeaveSettings",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationScores_ApplicationId",
                table: "ApplicationScores",
                column: "ApplicationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationNegotiations_ApplicationId",
                table: "ApplicationNegotiations",
                column: "ApplicationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationInterviews_ApplicationId",
                table: "ApplicationInterviews",
                column: "ApplicationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationFaceToViews_ApplicationId",
                table: "ApplicationFaceToViews",
                column: "ApplicationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_OrganizationId",
                table: "AspNetUsers",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_JobProfiles_Ranks_RankId",
                table: "JobProfiles",
                column: "RankId",
                principalTable: "Ranks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveSettings_CompanyInfos_CompanyId",
                table: "LeaveSettings",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveTypes_OrganizationInfos_OrganizationId",
                table: "LeaveTypes",
                column: "OrganizationId",
                principalTable: "OrganizationInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RankPermissions_Ranks_RankId",
                table: "RankPermissions",
                column: "RankId",
                principalTable: "Ranks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobProfiles_Ranks_RankId",
                table: "JobProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveSettings_CompanyInfos_CompanyId",
                table: "LeaveSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveTypes_OrganizationInfos_OrganizationId",
                table: "LeaveTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_RankPermissions_Ranks_RankId",
                table: "RankPermissions");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Ranks");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_LeaveTypes_OrganizationId",
                table: "LeaveTypes");

            migrationBuilder.DropIndex(
                name: "IX_LeaveSettings_CompanyId",
                table: "LeaveSettings");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationScores_ApplicationId",
                table: "ApplicationScores");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationNegotiations_ApplicationId",
                table: "ApplicationNegotiations");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationInterviews_ApplicationId",
                table: "ApplicationInterviews");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationFaceToViews_ApplicationId",
                table: "ApplicationFaceToViews");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SkillTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "SkillTypes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SkillGrades");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "SkillGrades");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "RankPermissions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "RankPermissions");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "RankPermissions");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "RankPermissions");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "RankPermissions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OrganizationInfos");

            migrationBuilder.DropColumn(
                name: "Directory",
                table: "OrganizationInfos");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "OrganizationInfos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OrganizationHeaders");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "OrganizationHeaders");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Onboardings");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Onboardings");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Lookups");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Lookups");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "LeaveTypes");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "LeaveTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "LeaveTypes");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "LeaveSettings");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "LeaveSettings");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "LeaveSettings");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "LeavePolicies");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "LeavePolicies");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "JobSkillLevels");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "JobSkillLevels");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "JobRequisitions");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "JobRequisitions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "JobProfiles");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "JobProfiles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "JobProfessions");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "JobProfessions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "JobCategories");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "JobCategories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EmployeeTransfers");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "EmployeeTransfers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EmployeeTimetables");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "EmployeeTimetables");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EmployeeStatutories");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "EmployeeStatutories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EmployeePensions");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "EmployeePensions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EmployeeLeaves");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "EmployeeLeaves");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EmployeeFamilies");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "EmployeeFamilies");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EmployeeExperiences");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "EmployeeExperiences");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EmployeeEmergencies");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "EmployeeEmergencies");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EmployeeEducations");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "EmployeeEducations");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EmployeeBank");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "EmployeeBank");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CompanyLeavePolicies");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "CompanyLeavePolicies");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "Directory",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "CompanyInfos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CompanyEmployees");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "CompanyEmployees");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ApplicationSkills");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ApplicationSkills");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ApplicationScores");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ApplicationScores");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ApplicationNegotiations");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ApplicationNegotiations");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ApplicationInterviews");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ApplicationInterviews");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ApplicationFaceToViews");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ApplicationFaceToViews");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Applicants");

            migrationBuilder.CreateTable(
                name: "CompanyRanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyRanks", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationScores_ApplicationId",
                table: "ApplicationScores",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationNegotiations_ApplicationId",
                table: "ApplicationNegotiations",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationInterviews_ApplicationId",
                table: "ApplicationInterviews",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationFaceToViews_ApplicationId",
                table: "ApplicationFaceToViews",
                column: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobProfiles_CompanyRanks_RankId",
                table: "JobProfiles",
                column: "RankId",
                principalTable: "CompanyRanks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RankPermissions_CompanyRanks_RankId",
                table: "RankPermissions",
                column: "RankId",
                principalTable: "CompanyRanks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
