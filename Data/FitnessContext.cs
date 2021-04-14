using FitPETZ.Models;
using Microsoft.EntityFrameworkCore;

namespace FitPETZ.Data
{
    public class FitnessContext : DbContext
    {
        public FitnessContext(DbContextOptions<FitnessContext> options) : base(options) { }
        public FitnessContext() : base() { }
        public DbSet<User> Users { get; set; }
        public DbSet<UserIdentity> UserIdentities { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<ChallengeAssignments> ChallengeAssignments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "FitPETZ.db");
            optionsBuilder.UseSqlite($"Filename={path}");
        }
    }
}