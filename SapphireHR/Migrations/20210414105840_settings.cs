using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class settings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeHODImprovementComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Strength = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaOfImprovement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeHODImprovementComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeHODImprovementComments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeInitiativeAchievements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BySelf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HODComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeInitiativeAchievements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeInitiativeAchievements_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeObservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BySelf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HODComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeObservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeObservations_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePersonalGoals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoalAchieved = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoalSet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePersonalGoals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeePersonalGoals_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProfGoalAchieveds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BySelf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HODComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProfGoalAchieveds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeProfGoalAchieveds_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProfGoalPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BySelf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HODComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProfGoalPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeProfGoalPlans_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeResponsibilityComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Strength = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaOfImprovement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeResponsibilityComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeResponsibilityComments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeROImprovementComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Strength = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaOfImprovement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeROImprovementComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeROImprovementComments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeRoleComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BySelf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HODComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRoleComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeRoleComments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTrainingRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BySelf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HODComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTrainingRequirements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeTrainingRequirements_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalExcellenceSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyPerfomanceIndicator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weightage = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalExcellenceSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProffesionalExcellenceSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyPerfomanceIndicator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weightage = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProffesionalExcellenceSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePersonalExcellences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SelfScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROScore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PersonalExcellenceSetting = table.Column<int>(type: "int", nullable: false),
                    PersonalExcellenceSettingsId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePersonalExcellences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeePersonalExcellences_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeePersonalExcellences_PersonalExcellenceSettings_PersonalExcellenceSettingsId",
                        column: x => x.PersonalExcellenceSettingsId,
                        principalTable: "PersonalExcellenceSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProffesionalExcellences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SelfScore = table.Column<int>(type: "int", nullable: false),
                    ROScore = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ProffesionalExcellenceSettingsId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProffesionalExcellences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeProffesionalExcellences_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProffesionalExcellences_ProffesionalExcellenceSettings_ProffesionalExcellenceSettingsId",
                        column: x => x.ProffesionalExcellenceSettingsId,
                        principalTable: "ProffesionalExcellenceSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeHODImprovementComments_EmployeeId",
                table: "EmployeeHODImprovementComments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInitiativeAchievements_EmployeeId",
                table: "EmployeeInitiativeAchievements",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeObservations_EmployeeId",
                table: "EmployeeObservations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePersonalExcellences_EmployeeId",
                table: "EmployeePersonalExcellences",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePersonalExcellences_PersonalExcellenceSettingsId",
                table: "EmployeePersonalExcellences",
                column: "PersonalExcellenceSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePersonalGoals_EmployeeId",
                table: "EmployeePersonalGoals",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProffesionalExcellences_EmployeeId",
                table: "EmployeeProffesionalExcellences",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProffesionalExcellences_ProffesionalExcellenceSettingsId",
                table: "EmployeeProffesionalExcellences",
                column: "ProffesionalExcellenceSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProfGoalAchieveds_EmployeeId",
                table: "EmployeeProfGoalAchieveds",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProfGoalPlans_EmployeeId",
                table: "EmployeeProfGoalPlans",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeResponsibilityComments_EmployeeId",
                table: "EmployeeResponsibilityComments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeROImprovementComments_EmployeeId",
                table: "EmployeeROImprovementComments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRoleComments_EmployeeId",
                table: "EmployeeRoleComments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTrainingRequirements_EmployeeId",
                table: "EmployeeTrainingRequirements",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeHODImprovementComments");

            migrationBuilder.DropTable(
                name: "EmployeeInitiativeAchievements");

            migrationBuilder.DropTable(
                name: "EmployeeObservations");

            migrationBuilder.DropTable(
                name: "EmployeePersonalExcellences");

            migrationBuilder.DropTable(
                name: "EmployeePersonalGoals");

            migrationBuilder.DropTable(
                name: "EmployeeProffesionalExcellences");

            migrationBuilder.DropTable(
                name: "EmployeeProfGoalAchieveds");

            migrationBuilder.DropTable(
                name: "EmployeeProfGoalPlans");

            migrationBuilder.DropTable(
                name: "EmployeeResponsibilityComments");

            migrationBuilder.DropTable(
                name: "EmployeeROImprovementComments");

            migrationBuilder.DropTable(
                name: "EmployeeRoleComments");

            migrationBuilder.DropTable(
                name: "EmployeeTrainingRequirements");

            migrationBuilder.DropTable(
                name: "PersonalExcellenceSettings");

            migrationBuilder.DropTable(
                name: "ProffesionalExcellenceSettings");
        }
    }
}
