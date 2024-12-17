using TabiSaki.Domain.Models;

namespace TabiSaki.Data.Repositories.Interfaces;

public interface ITripRepository
{
    public Task<Trip?> Create(Trip trip);

    public Task<IEnumerable<Trip>> GetAll();

    public Task<Trip?> GetById(long id);

    public Task<int> SaveChangesAsync();
}
