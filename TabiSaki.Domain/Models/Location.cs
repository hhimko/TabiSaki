namespace TabiSaki.Domain.Models;

public class Location
{
    public required Guid Id { get; init; }

    public required double Latitude { get; set; }

    public required double Longitude { get; set; }

    public ICollection<LocationSpot> Spots { get; set; } = [];

}