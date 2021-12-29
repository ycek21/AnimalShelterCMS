using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdoptionApplication>()
                .HasOne(c => c.User)
                .WithMany(u => u.AdoptionApplications).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<AdoptionApplication>()
                .HasOne(c => c.Animal)
                .WithMany(e => e.AdoptionApplications).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Walk>()
                .HasOne(c => c.Animal)
                .WithMany(e => e.Walks).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Walk>()
                .HasOne(c => c.User)
                .WithMany(e => e.Walks).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Donation>()
                .HasOne(c => c.User)
                .WithMany(e => e.Donations).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Donation>()
                .HasOne(c => c.Fundraiser)
                .WithMany(e => e.Donations).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(c => c.Animals)
                .WithOne(e => e.User).OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<User>()
                .HasMany(c => c.Walks)
                .WithOne(e => e.User).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Animal>()
                .HasOne(c => c.Size)
                .WithMany(e => e.Animals)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Animal>()
               .HasOne(c => c.Color)
               .WithMany(e => e.Animals)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Animal>()
               .HasOne(c => c.AnimalType)
               .WithMany(e => e.Animals)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Fundraiser>()
                .HasOne(c => c.User)
                .WithMany(e => e.Fundraisers)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Config>()
                .HasOne(c => c.User)
                .WithMany(e => e.Configs)
                .OnDelete(DeleteBehavior.SetNull);


            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Animal> Animals { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<AnimalType> AnimalTypes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<AdoptionApplication> AdoptionApplications { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Fundraiser> Fundraisers { get; set; }
    }
}