using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace LeafletClient.Models
{
    /** Record model based on Leaflet's LatLng object.
     *  https://leafletjs.com/reference.html#latlng
     */
    public readonly record struct LatLng
    {
        [JsonPropertyName("lat")]
        public required double Latitude { get; init; }

        [JsonPropertyName("lng")]
        public required double Longitude { get; init; }

        [JsonPropertyName("alt")]
        public double? Altitude { get; init; }


        [SetsRequiredMembers]
        public LatLng(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        [SetsRequiredMembers]
        public LatLng(double latitude, double longitude, double altitude)
        {
            Latitude = latitude;
            Longitude = longitude;
            Altitude = altitude;
        }
    }
}
