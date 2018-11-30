using Microsoft.EntityFrameworkCore;

namespace DemoConsole.Entities
{
    public class ActorDbContext : DbContext
    {
        
        public DbSet<Actor> Actors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Talent.db");
        }
    }
}
