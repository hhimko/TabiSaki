using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TabiSaki.Data.Entities;

[Table("Trips")]
internal class TripEntity
{
    [Key]
    public required long Id { get; init; }

    [MaxLength(64)]
    public required string Name { get; init; }

    public virtual ICollection<DestinationEntity> Destinations { get; set; } = [];
}
