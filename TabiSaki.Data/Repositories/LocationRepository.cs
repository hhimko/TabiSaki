using TabiSaki.Data.Database;
using TabiSaki.Data.Entities;
using TabiSaki.Data.Interfaces;
using TabiSaki.Domain.Models;

namespace TabiSaki.Data.Repositories;

internal class LocationRepository : ILocationRepository
{
    private readonly AppDbContext _context;


    public LocationRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Location> GetAll()
    {
        return [];
    }

    public Location GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}