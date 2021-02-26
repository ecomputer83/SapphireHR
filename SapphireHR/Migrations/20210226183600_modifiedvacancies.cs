using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class modifiedvacancies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_JobRequisitions_VacancyId",
                table: "JobRequisitions");

            migrationBuilder.CreateTable(
                name: "MailMessage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MailMessageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MailSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBodyHtml = table.Column<bool>(type: "bit", nullable: false),
                    IsSent = table.Column<bool>(type: "bit", nullable: false),
                    MailSentDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Template = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailMessage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailMessageQueue",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Template = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Payload = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailMessageQueue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemplateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemplateSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemplateBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBodyHtml = table.Column<int>(type: "int", nullable: false),
                    CopySender = table.Column<int>(type: "int", nullable: false),
                    IsSystem = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailMessageAddress",
                columns: table => new
                {
                    MailMessageAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MailMessageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    MailMessageId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailMessageAddress", x => x.MailMessageAddressId);
                    table.ForeignKey(
                        name: "FK_MailMessageAddress_MailMessage_MailMessageId1",
                        column: x => x.MailMessageId1,
                        principalTable: "MailMessage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MailMessageAttachment",
                columns: table => new
                {
                    MailMessageAttachmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MailMessageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    MailMessageId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailMessageAttachment", x => x.MailMessageAttachmentId);
                    table.ForeignKey(
                        name: "FK_MailMessageAttachment_MailMessage_MailMessageId1",
                        column: x => x.MailMessageId1,
                        principalTable: "MailMessage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobRequisitions_VacancyId",
                table: "JobRequisitions",
                column: "VacancyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobProfiles_CompanyId",
                table: "JobProfiles",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_MailMessageAddress_MailMessageId1",
                table: "MailMessageAddress",
                column: "MailMessageId1");

            migrationBuilder.CreateIndex(
                name: "IX_MailMessageAttachment_MailMessageId1",
                table: "MailMessageAttachment",
                column: "MailMessageId1");

            migrationBuilder.AddForeignKey(
                name: "FK_JobProfiles_CompanyInfos_CompanyId",
                table: "JobProfiles",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobProfiles_CompanyInfos_CompanyId",
                table: "JobProfiles");

            migrationBuilder.DropTable(
                name: "MailMessageAddress");

            migrationBuilder.DropTable(
                name: "MailMessageAttachment");

            migrationBuilder.DropTable(
                name: "MailMessageQueue");

            migrationBuilder.DropTable(
                name: "MailTemplate");

            migrationBuilder.DropTable(
                name: "MailMessage");

            migrationBuilder.DropIndex(
                name: "IX_JobRequisitions_VacancyId",
                table: "JobRequisitions");

            migrationBuilder.DropIndex(
                name: "IX_JobProfiles_CompanyId",
                table: "JobProfiles");

            migrationBuilder.CreateIndex(
                name: "IX_JobRequisitions_VacancyId",
                table: "JobRequisitions",
                column: "VacancyId");
        }
    }
}
