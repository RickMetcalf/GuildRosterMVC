using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GuildRosterMVC.Data.Migrations
{
    public partial class fixSpecialization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Specializations_SpecializationId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_SpecializationId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "SpecializationId",
                table: "Players");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SpecializationId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Players_SpecializationId",
                table: "Players",
                column: "SpecializationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Specializations_SpecializationId",
                table: "Players",
                column: "SpecializationId",
                principalTable: "Specializations",
                principalColumn: "Id");
        }
    }
}
