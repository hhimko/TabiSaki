using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TabiSaki.Data.Entities;

[Table("Locations")]
internal class LocationEntity
{
    [Key]
    public required Guid Id { get; init; }

    public required double Latitude { get; set; }

    public required double Longitude { get; set; }

    public ICollection<LocationSpotEntity> Spots { get; set; } = [];

}