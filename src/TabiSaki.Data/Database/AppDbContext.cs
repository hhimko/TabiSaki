using Microsoft.EntityFrameworkCore;
using TabiSaki.Data.Entities;

namespace TabiSaki.Data.Database;

internal class AppDbContext : DbContext
{
    public DbSet<LocationEntity> Locations { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
            
    }
}