namespace TabiSaki.Domain.Models;

public class Location
{
    public required long Id { get; init; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public IEnumerable<LocationSpot> Spots { get; set; } = [];

}