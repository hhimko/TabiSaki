using LeafletClient.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace LeafletClient.Components;

public partial class MapViewport : ComponentBase, IAsyncDisposable
{
    [Inject]
    private IJSRuntime JSRuntime { get; init; } = default!;

    [Parameter]
    public required string MapTilerApiKey { get; set; }

    [Parameter]
    public required string MapTilerStyle { get; set; }

    public bool IsInitialized => _module is not null && _context is not null;

    public delegate void OnMapInitializedHandler();
    public delegate Task OnMapInitializedHandlerAsync();
    public event OnMapInitializedHandler? OnMapInitialized;
    public event OnMapInitializedHandlerAsync? OnMapInitializedAsync;

    private IJSObjectReference? _module;
    private ElementReference _viewportElement;
    private IJSObjectReference? _context;


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            _module = await JSRuntime.InvokeAsync<IJSObjectReference>(
                "import", $"./_content/LeafletClient/Components/MapViewport.razor.js?v={DateTime.Now}"
            );

            await InitializeModuleAsync();
        }
    }

    public async Task SetViewAsync(LatLng latLng, int zoom)
    {
        if (IsInitialized)
        {
            await _module!.InvokeVoidAsync(
                "setView", _context, latLng, zoom
            );
        }
    }

    public async Task SetMarkerAsync(Marker marker)
    {
        if (IsInitialized)
        {
            await _module!.InvokeVoidAsync(
                "setMarker", _context, marker
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

    private async Task InitializeModuleAsync()
    {
        if (_module is not null)
        {
            var contextOptions = new { };
            _context = await _module.InvokeAsync<IJSObjectReference>(
                "createContext", contextOptions
            );

            if (_context is not null)
            {
                await _module.InvokeVoidAsync(
                    "initialize", _context, _viewportElement, MapTilerApiKey, MapTilerStyle
                );

                OnMapInitialized?.Invoke();
                OnMapInitializedAsync?.Invoke();
            }
        }
    }
}