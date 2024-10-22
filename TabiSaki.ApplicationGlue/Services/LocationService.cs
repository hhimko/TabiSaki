using TabiSaki.Application.Services;
using TabiSaki.Data.Interfaces;
using TabiSaki.Domain.Models;

namespace TabiSaki.ApplicationGlue.Services;

internal class LocationService : ILocationService
{
    private readonly ILocationRepository _repository;


    public LocationService(ILocationRepository repository)
    {
        _repository = repository;
    }
    public IEnumerable<Location> GetAll()
    {
        return _repository.GetAll();
    }
    public Location GetById(Guid id)
    {
        return _repository.GetById(id);
    }
}
