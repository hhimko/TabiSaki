using TabiSaki.Domain.Models;
using AutoMapper;

namespace TabiSaki.Data.Entities.Mapping;

internal class PlaceProfile : Profile
{
    public PlaceProfile()
    {
        CreateMap<PlaceEntity, Place>();
        CreateMap<Place, PlaceEntity>();
    }
}
