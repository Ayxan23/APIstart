using APIStart.Configurations;
using APIStart.Models;
using Microsoft.EntityFrameworkCore;

namespace APIStart.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> context) : base(context)
    {
    }

    public DbSet<Service> Services { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ServiceConfiguration).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}