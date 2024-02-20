using Microsoft.EntityFrameworkCore;
using PokemonApp.Models;

namespace PokemonApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PockemonOwner> PockemonOwners { get; set; }
        public DbSet<PockemonCategory> PockemonCategories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PockemonCategory>().HasKey(pc => new { pc.PokemonId, pc.CategoryId });
            modelBuilder.Entity<PockemonCategory>().HasOne(pc => pc.Pokemon).WithMany(pc => pc.PockemonCategories).HasForeignKey(pc => pc.PokemonId);
            modelBuilder.Entity<PockemonCategory>().HasOne(pc => pc.Category).WithMany(pc => pc.PockemonCategories).HasForeignKey(pc => pc.CategoryId);

            modelBuilder.Entity<PockemonOwner>().HasKey(po => new { po.PokemonId, po.OwnerId });
            modelBuilder.Entity<PockemonOwner>().HasOne(po => po.Pokemon).WithMany(po => po.PockemonOwners).HasForeignKey(po => po.PokemonId);
            modelBuilder.Entity<PockemonOwner>().HasOne(po => po.Owner).WithMany(po => po.PockemonOwners).HasForeignKey(po => po.OwnerId);
        }
    }
}