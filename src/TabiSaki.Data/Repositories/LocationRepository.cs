using TabiSaki.Data.Database;
using TabiSaki.Data.Entities;
using TabiSaki.Data.Repositories.Interfaces;
using TabiSaki.Domain.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace TabiSaki.Data.Repositories;

internal class LocationRepository : RepositoryBase, ILocationRepository
{
    public LocationRepository(AppDbContext context, IMapper mapper)
        : base(context, mapper)
    {
    }

    public async Task<Location?> Create(Location location)
    {
        var mapped = Mapper.Map<Location, LocationEntity>(location);
        await Context.Locations.AddAsync(mapped);
        return location;
    }

    public async Task<IEnumerable<Location>> GetAll()
    {
        var locations = await Context.Locations
            .Include(l => l.Places)
            .ToListAsync();

        return Mapper.Map<List<LocationEntity>, List<Location>>(locations);
    }

    public async Task<Location?> GetById(long id)
    {
        var location = await Context.Locations
            .Include(l => l.Places)
            .FirstOrDefaultAsync(l => l.Id == id);

        return location == null ? null : Mapper.Map<LocationEntity, Location>(location);
    }
}
