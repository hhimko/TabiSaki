using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace LeafletClient.Models;

/** Record model representing a map display-able marker. */
public record struct Marker
{
    public required long Id { get; init; }

    public required LatLng LatLng { get; set; }

    [JsonPropertyName("class")]
    public string CssClassName { get; set; }


    [SetsRequiredMembers]
    public Marker(long id, LatLng latLng, string cssClassName = "")
    {
        Id = id;
        LatLng = latLng;
        CssClassName = cssClassName;
    }
}