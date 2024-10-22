using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TabiSaki.Data.Entities;

[Table("LocationSpots")]
internal class LocationSpotEntity
{
    [Key]
    public required Guid Id { get; init; }

    [MaxLength(64)]
    public required string Name { get; set; } = String.Empty;

    public required Guid LocationId { get; init; }

}
