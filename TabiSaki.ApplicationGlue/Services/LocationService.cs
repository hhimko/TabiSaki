using TabiSaki.Application.Services;
using TabiSaki.Data.Repositories.Interfaces;
using TabiSaki.Domain.Models;

namespace TabiSaki.ApplicationGlue.Services;

internal class LocationService : ILocationService
{
    private readonly ILocationRepository _repository;


    public LocationService(ILocationRepository repository)
    {
        _repository = repository;
    }

    public async Task<Location?> Create(Location location)
    {
        var result = await _repository.Create(location);
        if (result == null)
        {
            return null;
        }

        await _repository.SaveChangesAsync();
        return result;
    }

    public async Task<IEnumerable<Location>> GetAll()
    {
        return await _repository.GetAll();
    }
    public async Task<Location?> GetById(long id)
    {
        return await _repository.GetById(id);
    }
}
