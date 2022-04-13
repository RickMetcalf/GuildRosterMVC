using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GuildRosterMVC.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GuildRanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuildRankName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildRanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WowClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WowClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specializations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    WowClassId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specializations_PlayerRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "PlayerRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Specializations_WowClasses_WowClassId",
                        column: x => x.WowClassId,
                        principalTable: "WowClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerName = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    WowClassId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: true),
                    GuildRankId = table.Column<int>(type: "int", nullable: false),
                    SpecializationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_GuildRanks_GuildRankId",
                        column: x => x.GuildRankId,
                        principalTable: "GuildRanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Players_PlayerRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "PlayerRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Players_Specializations_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specializations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Players_WowClasses_WowClassId",
                        column: x => x.WowClassId,
                        principalTable: "WowClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GuildRanks",
                columns: new[] { "Id", "GuildRankName" },
                values: new object[,]
                {
                    { 1, "Guild Master" },
                    { 2, "Officer" },
                    { 3, "Member" },
                    { 4, "Trial" }
                });

            migrationBuilder.InsertData(
                table: "PlayerRole",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { 1, "Tank" },
                    { 2, "Healer" },
                    { 3, "Melee DPS" },
                    { 4, "Ranged DPS" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "TeamName" },
                values: new object[,]
                {
                    { 1, "AOTC" },
                    { 2, "Mythic Raiding" },
                    { 3, "M+ Team 1" }
                });

            migrationBuilder.InsertData(
                table: "WowClasses",
                columns: new[] { "Id", "ClassName" },
                values: new object[,]
                {
                    { 1, "Death Knight" },
                    { 2, "Demon Hunter" },
                    { 3, "Druid" },
                    { 4, "Hunter" },
                    { 5, "Mage" },
                    { 6, "Monk" },
                    { 7, "Paladin" },
                    { 8, "Priest" },
                    { 9, "Rogue" },
                    { 10, "Shaman" },
                    { 11, "Warlock" },
                    { 12, "Warrior" }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "RoleId", "SpecName", "WowClassId" },
                values: new object[,]
                {
                    { 1, 1, "Blood", 1 },
                    { 2, 3, "Frost", 1 },
                    { 3, 3, "Blood", 1 },
                    { 4, 1, "Vengeance", 2 },
                    { 5, 3, "Havoc", 2 },
                    { 6, 1, "Guardian", 3 },
                    { 7, 2, "Restoration", 3 },
                    { 8, 3, "Feral", 3 },
                    { 9, 4, "Balance", 3 },
                    { 10, 3, "Survival", 4 },
                    { 11, 4, "Beast Mastery", 4 },
                    { 12, 4, "Marksmanship", 4 },
                    { 13, 4, "Fire", 5 },
                    { 14, 4, "Frost", 5 },
                    { 15, 4, "Arcane", 5 },
                    { 16, 1, "Brewmaster", 6 },
                    { 17, 2, "Mistweaver", 6 },
                    { 18, 3, "Windwalker", 6 },
                    { 19, 1, "Protection", 7 },
                    { 20, 2, "Holy", 7 },
                    { 21, 3, "Retribution", 7 },
                    { 22, 2, "Discipline", 8 },
                    { 23, 2, "Holy", 8 },
                    { 24, 4, "Shadow", 8 },
                    { 25, 3, "Outlaw", 9 },
                    { 26, 3, "Subtlety", 9 },
                    { 27, 3, "Assassination", 9 },
                    { 28, 2, "Restoration", 10 },
                    { 29, 3, "Enhancement", 10 },
                    { 30, 4, "Elemental", 10 },
                    { 31, 4, "Destruction", 11 },
                    { 32, 4, "Demonology", 11 },
                    { 33, 4, "Affliction", 11 },
                    { 34, 1, "Protection", 12 },
                    { 35, 3, "Fury", 12 },
                    { 36, 3, "Arms", 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_GuildRankId",
                table: "Players",
                column: "GuildRankId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_RoleId",
                table: "Players",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_SpecializationId",
                table: "Players",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_WowClassId",
                table: "Players",
                column: "WowClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Specializations_RoleId",
                table: "Specializations",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Specializations_WowClassId",
                table: "Specializations",
                column: "WowClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "GuildRanks");

            migrationBuilder.DropTable(
                name: "Specializations");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "PlayerRole");

            migrationBuilder.DropTable(
                name: "WowClasses");
        }
    }
}
