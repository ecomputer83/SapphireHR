using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class seedingmailTemplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "ProffesionalExcellenceSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "PersonalExcellenceSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "MailTemplate",
                columns: new[] { "Id", "CopySender", "CreatedAt", "CreatedBy", "IsBodyHtml", "IsSystem", "Priority", "Status", "TemplateBody", "TemplateCode", "TemplateName", "TemplateSubject", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, 0, new DateTime(2021, 4, 23, 15, 17, 10, 262, DateTimeKind.Local).AddTicks(5463), "SYSTEM", 1, false, "High", 1, "<p><img src=\"data:image/png;base64,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\" alt = \"\" width = \"63\" height = \"63\" /></p><p><em> Hi[name],</em></p><p><em><strong>[company] </strong> have added you to their company,                You have been assigned as <strong>[designation] </strong> of this company.</em></p><p><em> Check your account information below </em></p><p><em><strong> Account Link </strong>: [header] </em></p><p><em><strong> Employee Email </strong>: [email] </em></p><p><strong><em> Employee Password:[password]</em></strong></p>      <p><em> You are free to change your password at any time.</em></p>           <p> &nbsp;</p>             <p><em> Take care! </em><br /><em>[name] </em></p>                   <p> &nbsp;</p>                      <p> &nbsp;</p> ", "EMPLOYEE_REGISTRATION", "Employee Registration Account", "[company] Employee Registration Account", null, null });

            migrationBuilder.InsertData(
                table: "MailTemplate",
                columns: new[] { "Id", "CopySender", "CreatedAt", "CreatedBy", "IsBodyHtml", "IsSystem", "Priority", "Status", "TemplateBody", "TemplateCode", "TemplateName", "TemplateSubject", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 2, 0, new DateTime(2021, 4, 23, 15, 17, 10, 266, DateTimeKind.Local).AddTicks(266), "SYSTEM", 1, false, "High", 1, "<p><img src=\"data:image/png;base64,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\" alt = \"\" width = \"63\" height = \"63\" /></p><p><em> Hi[name],</em></p><p><em>Thank your for registering with Us. We&rsquo;re confident that Sapphire HRM will help you in Human Resource Managent of your organization.</em></p><p><em><strong>[org]</strong> has been registered with us.</em></p><p><em> Check your account information below </em></p><p><em><strong> Account Link </strong>: [header] </em></p><p><em><strong> Admin Email </strong>: [email] </em></p>      <p><em> You are free to change your password at any time.</em></p>           <p> &nbsp;</p>             <p><em> Take care! </em><br /><em>[name] </em></p>                   <p> &nbsp;</p>                      <p> &nbsp;</p> ", "WELCOME_MSG", "Welcome Message", "[org] Registration Account", null, null });

            migrationBuilder.InsertData(
                table: "MailTemplate",
                columns: new[] { "Id", "CopySender", "CreatedAt", "CreatedBy", "IsBodyHtml", "IsSystem", "Priority", "Status", "TemplateBody", "TemplateCode", "TemplateName", "TemplateSubject", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 3, 0, new DateTime(2021, 4, 23, 15, 17, 10, 266, DateTimeKind.Local).AddTicks(590), "SYSTEM", 1, false, "High", 1, "<p><img src=\"data:image/png;base64,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\" alt = \"\" width = \"63\" height = \"63\" /></p><p><em> Hi[name],</em></p><p><em><strong>[company]</strong> has been created, You have been assigned as <strong>HR</strong> of this company</em></p><p><em> Check your account information below </em></p><p><em><strong> Account Link </strong>: [header] </em></p><p><em><strong> HR Email </strong>: [email] </em></p><p><strong><em> HR Password:[password]</em></strong></p>      <p><em> You are free to change your password at any time.</em></p>           <p> &nbsp;</p>             <p><em> Take care! </em><br /><em>[name] </em></p>                   <p> &nbsp;</p>                      <p> &nbsp;</p> ", "HR_REGISTRATION", "HR Registration Account", "[company] HR Registration Account", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_ProffesionalExcellenceSettings_CompanyId",
                table: "ProffesionalExcellenceSettings",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalExcellenceSettings_CompanyId",
                table: "PersonalExcellenceSettings",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalExcellenceSettings_CompanyInfos_CompanyId",
                table: "PersonalExcellenceSettings",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProffesionalExcellenceSettings_CompanyInfos_CompanyId",
                table: "ProffesionalExcellenceSettings",
                column: "CompanyId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalExcellenceSettings_CompanyInfos_CompanyId",
                table: "PersonalExcellenceSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_ProffesionalExcellenceSettings_CompanyInfos_CompanyId",
                table: "ProffesionalExcellenceSettings");

            migrationBuilder.DropIndex(
                name: "IX_ProffesionalExcellenceSettings_CompanyId",
                table: "ProffesionalExcellenceSettings");

            migrationBuilder.DropIndex(
                name: "IX_PersonalExcellenceSettings_CompanyId",
                table: "PersonalExcellenceSettings");

            migrationBuilder.DeleteData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MailTemplate",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "ProffesionalExcellenceSettings");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "PersonalExcellenceSettings");
        }
    }
}
