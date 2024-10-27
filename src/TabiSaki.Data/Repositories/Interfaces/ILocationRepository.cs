using Microsoft.EntityFrameworkCore.Diagnostics;
using TabiSaki.Domain.Models;

namespace TabiSaki.Data.Repositories.Interfaces;

public interface ILocationRepository
{
    public Task<Location?> Create(Location location);

    public Task<IEnumerable<Location>> GetAll();

    public Task<Location?> GetById(long id);

    public Task<int> SaveChangesAsync();

}
