using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TabiSaki.Data.Entities;

[Table("Destinations")]
internal class DestinationEntity
{
    [Key]
    public required long Id { get; init; }

    public virtual required TripEntity Trip { get; init; }
}
