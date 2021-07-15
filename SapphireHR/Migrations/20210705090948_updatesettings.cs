using Microsoft.EntityFrameworkCore.Migrations;

namespace SapphireHR.Web.Migrations
{
    public partial class updatesettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KeyPerfomanceIndicator",
                table: "ProffesionalExcellenceSettings",
                newName: "KeyPerformanceIndicator");

            migrationBuilder.RenameColumn(
                name: "KeyPerfomanceIndicator",
                table: "PersonalExcellenceSettings",
                newName: "KeyPerformanceIndicator");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KeyPerformanceIndicator",
                table: "ProffesionalExcellenceSettings",
                newName: "KeyPerfomanceIndicator");

            migrationBuilder.RenameColumn(
                name: "KeyPerformanceIndicator",
                table: "PersonalExcellenceSettings",
                newName: "KeyPerfomanceIndicator");
        }
    }
}
