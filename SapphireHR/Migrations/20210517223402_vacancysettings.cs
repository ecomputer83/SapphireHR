using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class vacancysettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Vacancies_VacancyId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_VacancyId",
                table: "Applications");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Vacancysettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VacancyId = table.Column<int>(type: "int", nullable: false),
                    WelcomeMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RejectMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneInterviewChecked = table.Column<bool>(type: "bit", nullable: false),
                    WelcomeMessageToPhoneInterview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CareerTestingChecked = table.Column<bool>(type: "bit", nullable: false),
                    WelcomeMessageToCareerTesting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoogleFormsForCareerTesting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponseSpreadsheetForGoogleForms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetAutomaticScoring = table.Column<bool>(type: "bit", nullable: false),
                    ScorePerQuestion = table.Column<int>(type: "int", nullable: false),
                    PassAverageScore = table.Column<int>(type: "int", nullable: false),
                    QuestionsAndPossibleAnswerXML = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaceToFaceInterviewChecked = table.Column<bool>(type: "bit", nullable: false),
                    WelcomeMessageToFaceToFaceInterview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancysettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacancysettings_Vacancies_VacancyId",
                        column: x => x.VacancyId,
                        principalTable: "Vacancies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Lookups",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 5, 17, 23, 21, 57, 472, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.CreateIndex(
                name: "IX_Vacancysettings_VacancyId",
                table: "Vacancysettings",
                column: "VacancyId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vacancysettings");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Applications");

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

            migrationBuilder.CreateIndex(
                name: "IX_Applications_VacancyId",
                table: "Applications",
                column: "VacancyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Vacancies_VacancyId",
                table: "Applications",
                column: "VacancyId",
                principalTable: "Vacancies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
