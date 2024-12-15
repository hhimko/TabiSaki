namespace TabiSaki.Services.Interfaces.Web;

/// <summary>
/// Geolocation service result wrapper object. Can be either successfull or an error.
/// </summary>
public class GeolocationResult
{
    /// <summary>
    /// Device latitude in degrees.
    /// </summary>
    public double Latitude { get; init; }

    /// <summary>
    /// Device longitude in degrees.
    /// </summary>
    public double Longitude { get; init; }

    public string? ErrorMessage { get; init; }
    
    /// <summary>
    /// Whether the result is successfull, and the geolocation coordinates have been set.
    /// </summary>
    public bool IsSuccess => ErrorMessage is null;


    /// <summary>
    /// Initializes a successfull GeolocationResult object with device geolocation coordinates.
    /// </summary>
    public GeolocationResult(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    /// <summary>
    /// Initializes an unsuccessfull GeolocationResult object with a given error message.
    /// </summary>
    public GeolocationResult(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }
}

public interface IGeolocationService
{
    /// <summary>
    /// Returns whether the geolocation service is supported by the client device.
    /// </summary>
    public Task<bool> IsSupported();

    /// <summary>
    /// Tries to retrieve the client device's current geolocation coordinates.
    /// </summary>
    public Task<GeolocationResult> GetDeviceLocation();

    //public void WatchDeviceGeolocation(Action<GeolocationResult> callback);
}
