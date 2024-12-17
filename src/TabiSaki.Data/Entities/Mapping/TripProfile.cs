using TabiSaki.Domain.Models;
using AutoMapper;

namespace TabiSaki.Data.Entities.Mapping;

internal class TripProfile : Profile
{
    public TripProfile()
    {
        CreateMap<TripEntity, Trip>();
        CreateMap<Trip, TripEntity>();
    }
}
