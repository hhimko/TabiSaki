using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TabiSaki.Data.Entities;

[Table("LocationSpots")]
internal class LocationSpotEntity
{
    [Key]
    public required long Id { get; init; }

    [MaxLength(64)]
    public required string Name { get; set; } = String.Empty;

    [MaxLength(256)]
    public required string Description { get; set; } = String.Empty;

    [MaxLength(256)]
    public string? ExternalUrl { get; set; }

    public virtual required long LocationId { get; init; }

}
