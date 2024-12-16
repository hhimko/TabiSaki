using TabiSaki.Domain.Models;
using AutoMapper;

namespace TabiSaki.Data.Entities.Mapping;

internal class LocationSpotProfile : Profile
{
    public LocationSpotProfile()
    {
        CreateMap<PlaceEntity, Place>();
        CreateMap<Place, PlaceEntity>();
    }
}