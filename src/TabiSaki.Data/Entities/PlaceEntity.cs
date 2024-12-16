using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TabiSaki.Data.Entities;

[Table("Places")]
public class PlaceEntity
{
    [Key]
    public required long Id { get; init; }

    [MaxLength(64)]
    public required string Name { get; init; } = String.Empty;

    [MaxLength(256)]
    public required string Description { get; init; } = String.Empty;

    [MaxLength(256)]
    public string? ExternalUrl { get; init; }

    public virtual required LocationEntity Location { get; init; }
}
