using TabiSaki.Domain.Models;

namespace TabiSaki.Application.Services;

public interface ITripService
{
    public Task<Trip?> Create(Trip trip);

    public Task<IEnumerable<Trip>> GetAll();

    public Task<Trip?> GetById(long id);
}
