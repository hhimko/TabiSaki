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

    public required long LocationId { get; init; }

}
