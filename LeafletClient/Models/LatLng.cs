namespace LeafletClient.Models
{
    public readonly record struct LatLng
    {
        public double Latitude { get; init; }
        public double Longitude { get; init; }
    }
}
