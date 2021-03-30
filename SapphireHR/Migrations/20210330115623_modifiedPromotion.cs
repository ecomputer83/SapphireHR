using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class modifiedPromotion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpensePromotions_Designations_FromPromotionId",
                table: "ExpensePromotions");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpensePromotions_Designations_ToPromotionId",
                table: "ExpensePromotions");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpensePromotions_Employees_EmployeeId",
                table: "ExpensePromotions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExpensePromotions",
                table: "ExpensePromotions");

            migrationBuilder.DropIndex(
                name: "IX_ExpensePromotions_FromPromotionId",
                table: "ExpensePromotions");

            migrationBuilder.DropIndex(
                name: "IX_ExpensePromotions_ToPromotionId",
                table: "ExpensePromotions");

            migrationBuilder.DropColumn(
                name: "FromPromotionId",
                table: "ExpensePromotions");

            migrationBuilder.DropColumn(
                name: "ToPromotionId",
                table: "ExpensePromotions");

            migrationBuilder.RenameTable(
                name: "ExpensePromotions",
                newName: "EmployeePromotions");

            migrationBuilder.RenameIndex(
                name: "IX_ExpensePromotions_EmployeeId",
                table: "EmployeePromotions",
                newName: "IX_EmployeePromotions_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeePromotions",
                table: "EmployeePromotions",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePromotions_From",
                table: "EmployeePromotions",
                column: "From");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePromotions_To",
                table: "EmployeePromotions",
                column: "To");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePromotions_Designations_From",
                table: "EmployeePromotions",
                column: "From",
                principalTable: "Designations",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePromotions_Designations_To",
                table: "EmployeePromotions",
                column: "To",
                principalTable: "Designations",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePromotions_Employees_EmployeeId",
                table: "EmployeePromotions",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePromotions_Designations_From",
                table: "EmployeePromotions");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePromotions_Designations_To",
                table: "EmployeePromotions");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePromotions_Employees_EmployeeId",
                table: "EmployeePromotions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeePromotions",
                table: "EmployeePromotions");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePromotions_From",
                table: "EmployeePromotions");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePromotions_To",
                table: "EmployeePromotions");

            migrationBuilder.RenameTable(
                name: "EmployeePromotions",
                newName: "ExpensePromotions");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeePromotions_EmployeeId",
                table: "ExpensePromotions",
                newName: "IX_ExpensePromotions_EmployeeId");

            migrationBuilder.AddColumn<int>(
                name: "FromPromotionId",
                table: "ExpensePromotions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToPromotionId",
                table: "ExpensePromotions",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExpensePromotions",
                table: "ExpensePromotions",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ExpensePromotions_FromPromotionId",
                table: "ExpensePromotions",
                column: "FromPromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpensePromotions_ToPromotionId",
                table: "ExpensePromotions",
                column: "ToPromotionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpensePromotions_Designations_FromPromotionId",
                table: "ExpensePromotions",
                column: "FromPromotionId",
                principalTable: "Designations",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpensePromotions_Designations_ToPromotionId",
                table: "ExpensePromotions",
                column: "ToPromotionId",
                principalTable: "Designations",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpensePromotions_Employees_EmployeeId",
                table: "ExpensePromotions",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
