using I2STechnical.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Ensure that RegistrationNumber is the primary key
        modelBuilder.Entity<Vehicle>()
            .HasKey(v => v.RegistrationNumber);

        base.OnModelCreating(modelBuilder);
    }
}
