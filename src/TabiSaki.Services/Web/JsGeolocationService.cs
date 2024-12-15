using TabiSaki.Services.Interfaces.Web;

namespace TabiSaki.Services.Web;

public class JsGeolocationService : IGeolocationService, IAsyncDisposable
{
    public async Task<bool> IsSupported()
    {
        throw new NotImplementedException();
    }

    public async Task<GeolocationResult> GetDeviceLocation()
    {
        throw new NotImplementedException();
    }

    public ValueTask DisposeAsync()
    {
        throw new NotImplementedException();
    }
}
