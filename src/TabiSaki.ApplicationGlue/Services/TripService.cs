using TabiSaki.Application.Services;
using TabiSaki.Data.Repositories.Interfaces;
using TabiSaki.Domain.Models;

namespace TabiSaki.ApplicationGlue.Services;

internal class TripService : ITripService
{
    private readonly ITripRepository _repository;


    public TripService(ITripRepository repository)
    {
        _repository = repository;
    }

    public async Task<Trip?> Create(Trip trip)
    {
        var result = await _repository.Create(trip);
        if (result == null)
        {
            return null;
        }

        await _repository.SaveChangesAsync();
        return result;
    }

    public async Task<IEnumerable<Trip>> GetAll()
    {
        return await _repository.GetAll();
    }

    public async Task<Trip?> GetById(long id)
    {
        return await _repository.GetById(id);
    }
}
