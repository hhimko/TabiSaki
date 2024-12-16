using Microsoft.EntityFrameworkCore;
using TabiSaki.Data.Database;
using TabiSaki.Data.Entities;
using TabiSaki.Data.Repositories.Interfaces;
using TabiSaki.Domain.Models;
using AutoMapper;

namespace TabiSaki.Data.Repositories;

internal class LocationRepository : ILocationRepository
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;


    public LocationRepository(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Location?> Create(Location location)
    {
        var mapped = _mapper.Map<Location, LocationEntity>(location);
        await _context.Locations.AddAsync(mapped);
        return location;
    }

    public async Task<IEnumerable<Location>> GetAll()
    {
        var locations = await _context.Locations
            .Include(l => l.Places)
            .ToListAsync();

        return _mapper.Map<List<LocationEntity>, List<Location>>(locations);
    }

    public async Task<Location?> GetById(long id)
    {
        var location = await _context.Locations
            .Include(l => l.Places)
            .FirstOrDefaultAsync(l => l.Id == id);

        return location == null ? null : _mapper.Map<LocationEntity, Location>(location);
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
