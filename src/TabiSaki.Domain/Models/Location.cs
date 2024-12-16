namespace TabiSaki.Domain.Models;

public class Location
{
    public required long Id { get; init; }

    /// <summary>
    /// Latitude in degrees. Must be in [-90, 90] range.
    /// </summary>
    public required double Latitude { get; init; }

    /// <summary>
    /// Longitude in degrees. Must be in [-180, 180] range.
    /// </summary>
    public required double Longitude { get; init; }

    public IEnumerable<Place> Places { get; init; } = [];
}
