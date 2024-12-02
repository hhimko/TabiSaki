using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace TabiSaki.Components.Timeline;

public partial class TimelineComponent : ComponentBase, IAsyncDisposable
{
    [Inject]
    private IJSRuntime JSRuntime { get; init; } = default!;

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object> AdditionalAttributes { get; init; } = new Dictionary<string, object>();

    private ElementReference _containerElement;
    private IJSObjectReference? _module;

    private IReadOnlyDictionary<string, object>? _attributes;


    protected override void OnParametersSet()
    {
        var constClasses = $"";
        var classes = $"{constClasses} {AdditionalAttributes.GetValueOrDefault("class", "")}".Trim();

        _attributes = AdditionalAttributes.Where(x => x.Key != "class" && x.Key != "style")
            .Append(KeyValuePair.Create("class", (object)classes))
            .ToDictionary(x => x.Key, x => x.Value);
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            _module = await JSRuntime.InvokeAsync<IJSObjectReference>(
                "import", $"./_content/TabiSaki.Components/Timeline/TimelineComponent.razor.js?v={DateTime.Now}"
            );

            await _module!.InvokeVoidAsync(
                "initialize", _containerElement
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