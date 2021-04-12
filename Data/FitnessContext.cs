using FitPETZ.Models;
using Microsoft.EntityFrameworkCore;

namespace FitPETZ.Data
{
    public class FitnessContext : DbContext
    {
        public FitnessContext(DbContextOptions<FitnessContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<ChallengeAssignments> ChallengeAssignments { get; set; }
    }
}