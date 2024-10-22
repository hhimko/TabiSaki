using TabiSaki.Domain.Models;

namespace TabiSaki.Application.Services;

public interface ILocationService
{
    public IEnumerable<Location> GetAll();

    public Location GetById(Guid id);

}