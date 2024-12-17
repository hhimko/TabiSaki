using AutoMapper;
using TabiSaki.Data.Database;

namespace TabiSaki.Data.Repositories;

/// <summary>
/// Base abstract class for infrastructure level repositories
/// </summary>
internal abstract class RepositoryBase
{
    protected readonly AppDbContext Context;
    protected readonly IMapper Mapper;


    protected RepositoryBase(AppDbContext context, IMapper mapper)
    {
        Context = context;
        Mapper = mapper;
    }

    public async Task<int> SaveChangesAsync()
    {
        return await Context.SaveChangesAsync();
    }
}
