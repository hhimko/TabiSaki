using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TabiSaki.Data.Entities;

[Table("Locations")]
public class LocationEntity
{
    [Key]
    public required long Id { get; init; }

    [Required, Range(-90.0, 90.0)]
    public required double Latitude { get; init; }

    [Required, Range(-180.0, 180.0)]
    public required double Longitude { get; init; }

    public virtual ICollection<PlaceEntity> Places { get; init; } = [];
}
