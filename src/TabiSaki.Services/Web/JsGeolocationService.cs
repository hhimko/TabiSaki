using TabiSaki.Services.Interfaces.Web;

namespace TabiSaki.Services.Web;

public class JsGeolocationService : IGeolocationService, IAsyncDisposable
{
    public async Task<bool> IsSupported()
    {
        return await Task.FromResult(false);
    }

    public async Task<GeolocationResult> GetDeviceLocation()
    {
        return await Task.FromResult(new GeolocationResult("not implemented"));
    }

    public ValueTask DisposeAsync()
    {
        throw new NotImplementedException();
    }
}
