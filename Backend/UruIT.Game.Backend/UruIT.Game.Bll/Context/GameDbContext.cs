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

        public DbSet<User> Users { get; set; }
        public DbSet<Move> Moves { get; set; }
        public DbSet<Model.Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasMany(p => p.Games)
            .WithOne(b => b.User)
            .HasForeignKey(b => b.UserId);

            modelBuilder.Entity<Game.Model.Game>();
            modelBuilder.Entity<Move>();
        }
    }
}