using TabiSaki.Application.Services;
using TabiSaki.Domain.Models;

namespace TabiSaki.Services.Data;

public class DataSeederService
{
    private readonly ILocationService _locationService;

    public DataSeederService(ILocationService locationService)
    {
        _locationService = locationService;
    }

    public async Task SeedSampleDataAsync()
    {
        await _locationService.Create(new Location
        {
            Id = 1,
            Latitude = 35.649269,
            Longitude = 139.789665,
            Spots = [ 
                new LocationSpot { Id = 1, Name = "Test1" }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 2,
            Latitude = 35.7,
            Longitude = 139.7,
            Spots = [
                new LocationSpot { Id = 2, Name = "Test2" }
            ]
        });
    }
}
