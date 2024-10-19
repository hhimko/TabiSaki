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

        private Lazy<Task<IJSObjectReference>>? _moduleTask;
        private bool IsModuleCreated => _moduleTask != null && _moduleTask.IsValueCreated;

        private ElementReference _viewportElement;
        private IJSObjectReference? _leafletContext;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                _moduleTask = new Lazy<Task<IJSObjectReference>>(
                    () => JSRuntime.InvokeAsync<IJSObjectReference>(
                        "import", "./_content/LeafletClient/Components/MapViewport.razor.js"
                    ).AsTask()
                );

                var module = await _moduleTask!.Value;
                _leafletContext = await module.InvokeAsync<IJSObjectReference>(
                    "initialize", _viewportElement, MapTilerApiKey, MapTilerStyle
                );
            }
        }

        public async Task SetView(LatLng latLng, int zoom)
        {
            if (IsModuleCreated)
            {
                var module = await _moduleTask!.Value;
                await module.InvokeVoidAsync(
                    "setView", _leafletContext, latLng.Latitude, latLng.Longitude, zoom
                );
            }
        }

        public async ValueTask DisposeAsync()
        {
            if (IsModuleCreated)
            {
                var module = await _moduleTask!.Value;
                try
                {
                    await module.DisposeAsync();
                }
                catch (JSDisconnectedException)
                {
                    // Ignore
                }
            }
        }
    }
}
