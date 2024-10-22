using TabiSaki.Domain.Models;

namespace TabiSaki.Application.Services;

public interface ILocationService
{
    public Task<Location?> Create(Location location);

    public Task<IEnumerable<Location>> GetAll();

    public Task<Location?> GetById(long id);

}
