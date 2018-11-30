using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoExistingDbMVC.Models
{
    public partial class ActorDbContext : DbContext
    {
        public virtual DbSet<Actors> Actors { get; set; }

        public ActorDbContext(DbContextOptions<ActorDbContext> options) : base(options)
        { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}