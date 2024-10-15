using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using Microsoft.JSInterop;

namespace WebApp.Components.Pages
{
    public partial class Home : ComponentBase, IAsyncDisposable
    {
        [Inject]
        private IOptions<AppSettings> Settings { get; set; } = default!;

        [Inject]
        private IJSRuntime JS { get; set; } = default!;

        private IJSObjectReference? _jsModule;


        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                const string modulePath = "./Components/Pages/Home.razor.js";
                _jsModule = await JS.InvokeAsync<IJSObjectReference>("import", modulePath);

                await _jsModule.InvokeVoidAsync("initializeMap", Settings.Value.MapTilerApiKey);
            }
        }
        async ValueTask IAsyncDisposable.DisposeAsync()
        {
            if (_jsModule is not null)
            {
                try
                {
                    await _jsModule.DisposeAsync();
                }
                catch (JSDisconnectedException)
                {
                    // Ignore
                }
            }
        }
    }
}
