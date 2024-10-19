using LeafletClient.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace LeafletClient.Components
{
    public partial class MapViewport : ComponentBase, IAsyncDisposable
    {
        [Inject]
        private IJSRuntime JSRuntime { get; init; } = default!;

        [Parameter]
        public required string MapTilerApiKey { get; set; }

        [Parameter]
        public required string MapTilerStyle { get; set; }

        public delegate void OnMapInitializedHandler();
        public delegate Task OnMapInitializedHandlerAsync();
        public event OnMapInitializedHandler? OnMapInitialized;
        public event OnMapInitializedHandlerAsync? OnMapInitializedAsync;

        private IJSObjectReference? _module;
        private ElementReference _viewportElement;
        private IJSObjectReference? _leafletContext;


        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                _module = await JSRuntime.InvokeAsync<IJSObjectReference>(
                    "import", "./_content/LeafletClient/Components/MapViewport.razor.js"
                );

                _leafletContext = await _module.InvokeAsync<IJSObjectReference>(
                    "initialize", _viewportElement, MapTilerApiKey, MapTilerStyle
                );

                OnMapInitialized?.Invoke();
                OnMapInitializedAsync?.Invoke();
            }
        }

        public async Task SetView(LatLng latLng, int zoom)
        {
            if (_module is not null)
            {
                await _module.InvokeVoidAsync(
                    "setView", _leafletContext, latLng.Latitude, latLng.Longitude, zoom
                );
            }
        }

        public async ValueTask DisposeAsync()
        {
            if (_module is not null)
            {
                try
                {
                    await _module.DisposeAsync();
                }
                catch (JSDisconnectedException)
                {
                    // Ignore
                }
            }
        }
    }
}
