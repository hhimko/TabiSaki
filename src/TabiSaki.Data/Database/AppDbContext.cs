using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using TabiSaki.Data.Entities;
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")] // Required by EF lazy loading proxies

namespace TabiSaki.Data.Database;

internal class AppDbContext : DbContext
{
    public DbSet<LocationEntity> Locations { get; init; }


    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
            
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}