using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TabiSaki.Data.Entities;

[Table("Locations")]
internal class LocationEntity
{
    [Key]
    public required long Id { get; init; }

    public required double Latitude { get; set; }

    public required double Longitude { get; set; }

    public virtual ICollection<LocationSpotEntity> Spots { get; set; } = [];

}