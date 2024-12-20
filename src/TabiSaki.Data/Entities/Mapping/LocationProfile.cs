﻿using TabiSaki.Domain.Models;
using AutoMapper;

namespace TabiSaki.Data.Entities.Mapping;

internal class LocationProfile : Profile
{
    public LocationProfile()
    {
        CreateMap<LocationEntity, Location>();
        CreateMap<Location, LocationEntity>();
    }
}
