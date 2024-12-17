using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TabiSaki.Data.Database;
using TabiSaki.Data.Entities;
using TabiSaki.Data.Repositories.Interfaces;
using TabiSaki.Domain.Models;

namespace TabiSaki.Data.Repositories;

internal class TripRepository : RepositoryBase, ITripRepository
{
    public TripRepository(AppDbContext context, IMapper mapper)
        : base(context, mapper)
    {
    }

    public async Task<Trip?> Create(Trip trip)
    {
        var mapped = Mapper.Map<Trip, TripEntity>(trip);
        await Context.Trips.AddAsync(mapped);
        return trip;
    }

    public async Task<IEnumerable<Trip>> GetAll()
    {
        var trips = await Context.Trips
            .ToListAsync();

        return Mapper.Map<List<TripEntity>, List<Trip>>(trips);
    }

    public async Task<Trip?> GetById(long id)
    {
        var trip = await Context.Trips
            .FirstOrDefaultAsync(l => l.Id == id);

        return trip == null ? null : Mapper.Map<TripEntity, Trip>(trip);
    }
}
