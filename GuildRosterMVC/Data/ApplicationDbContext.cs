using GuildRosterModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GuildRosterMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext() : base()
        {

        }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerRole> PlayerRole { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<WowClass> WowClasses { get; set; }
        public DbSet<GuildRank> GuildRanks { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<WowClass>(a =>
            {
                a.HasData(new WowClass() { Id = 1, ClassName = "Death Knight" },
                          new WowClass() { Id = 2, ClassName = "Demon Hunter" },
                          new WowClass() { Id = 3, ClassName = "Druid" },
                          new WowClass() { Id = 4, ClassName = "Hunter" },
                          new WowClass() { Id = 5, ClassName = "Mage" },
                          new WowClass() { Id = 6, ClassName = "Monk" },
                          new WowClass() { Id = 7, ClassName = "Paladin" },
                          new WowClass() { Id = 8, ClassName = "Priest" },
                          new WowClass() { Id = 9, ClassName = "Rogue" },
                          new WowClass() { Id = 10, ClassName = "Shaman" },
                          new WowClass() { Id = 11, ClassName = "Warlock" },
                          new WowClass() { Id = 12, ClassName = "Warrior" }
                );
            });
            modelBuilder.Entity<PlayerRole>(b =>
            {
                b.HasData(new PlayerRole() { Id = 1, RoleName = "Tank" },
                          new PlayerRole() { Id = 2, RoleName = "Healer" },
                          new PlayerRole() { Id = 3, RoleName = "Melee DPS" },
                          new PlayerRole() { Id = 4, RoleName = "Ranged DPS" }

                );
            });
            modelBuilder.Entity<Specialization>(c =>
            {
                c.HasData(new Specialization() { Id = 1, SpecName = "Blood", WowClassId = 1, RoleId = 1 },
                          new Specialization() { Id = 2, SpecName = "Frost", WowClassId = 1, RoleId = 3 },
                          new Specialization() { Id = 3, SpecName = "Blood", WowClassId = 1, RoleId = 3 },
                          new Specialization() { Id = 4, SpecName = "Vengeance", WowClassId = 2, RoleId = 1 },
                          new Specialization() { Id = 5, SpecName = "Havoc", WowClassId = 2, RoleId = 3 },
                          new Specialization() { Id = 6, SpecName = "Guardian", WowClassId = 3, RoleId = 1 },
                          new Specialization() { Id = 7, SpecName = "Restoration", WowClassId = 3, RoleId = 2 },
                          new Specialization() { Id = 8, SpecName = "Feral", WowClassId = 3, RoleId = 3 },
                          new Specialization() { Id = 9, SpecName = "Balance", WowClassId = 3, RoleId = 4 },
                          new Specialization() { Id = 10, SpecName = "Survival", WowClassId = 4, RoleId = 3 },
                          new Specialization() { Id = 11, SpecName = "Beast Mastery", WowClassId = 4, RoleId = 4 },
                          new Specialization() { Id = 12, SpecName = "Marksmanship", WowClassId = 4, RoleId = 4 },
                          new Specialization() { Id = 13, SpecName = "Fire", WowClassId = 5, RoleId = 4 },
                          new Specialization() { Id = 14, SpecName = "Frost", WowClassId = 5, RoleId = 4 },
                          new Specialization() { Id = 15, SpecName = "Arcane", WowClassId = 5, RoleId = 4 },
                          new Specialization() { Id = 16, SpecName = "Brewmaster", WowClassId = 6, RoleId = 1 },
                          new Specialization() { Id = 17, SpecName = "Mistweaver", WowClassId = 6, RoleId = 2 },
                          new Specialization() { Id = 18, SpecName = "Windwalker", WowClassId = 6, RoleId = 3 },
                          new Specialization() { Id = 19, SpecName = "Protection", WowClassId = 7, RoleId = 1 },
                          new Specialization() { Id = 20, SpecName = "Holy", WowClassId = 7, RoleId = 2 },
                          new Specialization() { Id = 21, SpecName = "Retribution", WowClassId = 7, RoleId = 3 },
                          new Specialization() { Id = 22, SpecName = "Discipline", WowClassId = 8, RoleId = 2 },
                          new Specialization() { Id = 23, SpecName = "Holy", WowClassId = 8, RoleId = 2 },
                          new Specialization() { Id = 24, SpecName = "Shadow", WowClassId = 8, RoleId = 4 },
                          new Specialization() { Id = 25, SpecName = "Outlaw", WowClassId = 9, RoleId = 3 },
                          new Specialization() { Id = 26, SpecName = "Subtlety", WowClassId = 9, RoleId = 3 },
                          new Specialization() { Id = 27, SpecName = "Assassination", WowClassId = 9, RoleId = 3 },
                          new Specialization() { Id = 28, SpecName = "Restoration", WowClassId = 10, RoleId = 2 },
                          new Specialization() { Id = 29, SpecName = "Enhancement", WowClassId = 10, RoleId = 3 },
                          new Specialization() { Id = 30, SpecName = "Elemental", WowClassId = 10, RoleId = 4 },
                          new Specialization() { Id = 31, SpecName = "Destruction", WowClassId = 11, RoleId = 4 },
                          new Specialization() { Id = 32, SpecName = "Demonology", WowClassId = 11, RoleId = 4 },
                          new Specialization() { Id = 33, SpecName = "Affliction", WowClassId = 11, RoleId = 4 },
                          new Specialization() { Id = 34, SpecName = "Protection", WowClassId = 12, RoleId = 1 },
                          new Specialization() { Id = 35, SpecName = "Fury", WowClassId = 12, RoleId = 3 },
                          new Specialization() { Id = 36, SpecName = "Arms", WowClassId = 12, RoleId = 3 }
                    );
            });
            modelBuilder.Entity<GuildRank>(b =>
            {
                b.HasData(new GuildRank() { Id = 1, GuildRankName = "Guild Master" },
                          new GuildRank() { Id = 2, GuildRankName = "Officer" },
                          new GuildRank() { Id = 3, GuildRankName = "Member" },
                          new GuildRank() { Id = 4, GuildRankName = "Trial" }

                );
            });
            modelBuilder.Entity<Team>(b =>
            {
                b.HasData(new Team() { Id = 1, TeamName = "AOTC" },
                          new Team() { Id = 2, TeamName = "Mythic Raiding" },
                          new Team() { Id= 3, TeamName = "M+ Team 1"}
                );
            });

        }

    }
}