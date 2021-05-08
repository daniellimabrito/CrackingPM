using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DLB.CrackingPM.Services.Stakeholder.Data.Migrations
{
    public partial class initStakeholderConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "stakeholders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InfluenceOther = table.Column<int>(type: "int", nullable: false),
                    DirectResourceControl = table.Column<int>(type: "int", nullable: false),
                    InterestLevelTechnical = table.Column<int>(type: "int", nullable: false),
                    InterestLevelNonTechnical = table.Column<int>(type: "int", nullable: false),
                    PowerInProduct = table.Column<int>(type: "int", nullable: false),
                    Knowledge = table.Column<int>(type: "int", nullable: false),
                    Accessibility = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stakeholders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "stakeholders");
        }
    }
}
