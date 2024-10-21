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


        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                MapViewport.OnMapInitializedAsync += OnMapInitializedAsync;
            }
        }

        private async Task OnMapInitializedAsync()
        {
            var latLng = new LatLng(35.8, 139.6);
            await MapViewport.SetViewAsync(latLng, 9);
            await MapViewport.SetMarkerAsync(new Marker(0, latLng, cssClassName: "test-marker"));
        }
    }
}
