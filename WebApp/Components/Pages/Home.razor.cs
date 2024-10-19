using LeafletClient.Components;
using LeafletClient.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;

namespace WebApp.Components.Pages
{
    public partial class Home : ComponentBase
    {
        [Inject]
        private IOptions<AppSettings> Settings { get; init; } = default!;

        private MapViewport MapViewport { get; set; } = default!;

        private string MapTilerApiKey => Settings.Value.MapTilerApiKey;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await Task.Delay(200);
            await MapViewport.SetView(new LatLng(), 5);
        }
    }
}
