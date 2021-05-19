using Microsoft.EntityFrameworkCore.Migrations;

namespace DLB.CrackingPM.Services.Stakeholder.Data.Migrations
{
    public partial class newColumnsPowerInProjectInterestInProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "InterestInProject",
                table: "stakeholders",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PowerInProject",
                table: "stakeholders",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InterestInProject",
                table: "stakeholders");

            migrationBuilder.DropColumn(
                name: "PowerInProject",
                table: "stakeholders");
        }
    }
}
