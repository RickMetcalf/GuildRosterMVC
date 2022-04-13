using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GuildRosterMVC.Data.Migrations
{
    public partial class AddedSpec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SpecializationId",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecializationId",
                table: "Players");
        }
    }
}
