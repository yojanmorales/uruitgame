using Microsoft.EntityFrameworkCore;
using UruIT.Game.Bll.Context;
using UruIT.Game.Model;

namespace UruIT.Game.Bll
{
    public class GameDbContext : DbContext, IGameDbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options)
    : base(options)
        {
        }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
        }
    }
}