using Microsoft.EntityFrameworkCore.Migrations;

namespace ResearchProject.DAL.Migrations
{
    public partial class types : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnimalType",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnimalType",
                table: "Pets");
        }
    }
}
