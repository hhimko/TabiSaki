using TabiSaki.Services.Interfaces.Web;

namespace TabiSaki.Services.Web;

public class MockGeolocationService : IGeolocationService
{
    public async Task<bool> IsSupported()
    {
        return await Task.FromResult(true);
    }

    public async Task<GeolocationResult> GetDeviceLocation()
    {
        var result = new GeolocationResult(35.681591999906615, 139.76508684216788);
        return await Task.FromResult(result);
    }
}
