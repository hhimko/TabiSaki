namespace TabiSaki.Domain.Models;

public class LocationSpot
{
    public required Guid Id { get; init; }

    public string Name { get; set; } = String.Empty;

}