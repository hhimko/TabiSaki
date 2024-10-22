using TabiSaki.Domain.Models;

namespace TabiSaki.Data.Interfaces;

public interface ILocationRepository
{
    public IEnumerable<Location> GetAll();

    public Location GetById(Guid id);

}
