using System.ComponentModel.DataAnnotations;

namespace TabiSaki.Domain.Models;

public class LocationSpot
{
    public required long Id { get; init; }

    public string Name { get; set; } = String.Empty;

    public string Description { get; set; } = String.Empty;

    public string? ExternalUrl { get; set; }

}