using TabiSaki.Domain.Models;
using AutoMapper;

namespace TabiSaki.Data.Entities.Profiles;

internal class LocationSpotProfile : Profile
{
    public LocationSpotProfile()
    {
        CreateMap<LocationSpotEntity, LocationSpot>();
        CreateMap<LocationSpot, LocationSpotEntity>();
    }
}