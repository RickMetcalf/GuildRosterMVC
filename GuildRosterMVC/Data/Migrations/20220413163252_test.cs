using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GuildRosterMVC.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Players_SpecializationId",
                table: "Players",
                column: "SpecializationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Specializations_SpecializationId",
                table: "Players",
                column: "SpecializationId",
                principalTable: "Specializations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Specializations_SpecializationId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_SpecializationId",
                table: "Players");
        }
    }
}
