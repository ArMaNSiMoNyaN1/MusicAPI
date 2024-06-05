using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Signer> Signers { get; set; }

    public DbSet<Track> Tracks { get; set; }

    public DbSet<Album> Albums { get; set; }

    public DbSet<Categories> Categories { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categories>().HasKey(c =>c.Name);
    }
}