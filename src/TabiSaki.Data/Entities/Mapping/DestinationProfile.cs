using TabiSaki.Domain.Models;
using AutoMapper;

namespace TabiSaki.Data.Entities.Mapping;

internal class DestinationProfile : Profile
{
    public DestinationProfile()
    {
        CreateMap<DestinationEntity, Destination>();
        CreateMap<Destination, DestinationEntity>();
    }
}
