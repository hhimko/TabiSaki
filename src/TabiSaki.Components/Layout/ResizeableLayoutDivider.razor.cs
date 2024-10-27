using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace TabiSaki.Components.Layout;

public partial class ResizeableLayoutDivider : ComponentBase, IAsyncDisposable
{
    public enum LayoutOrientation
    {
        Vertical, 
        Horizontal
    }

    [Inject]
    private IJSRuntime JSRuntime { get; init; } = default!;

    [Parameter, EditorRequired]
    public required RenderFragment TopLeftChild { get; init; }

    [Parameter, EditorRequired]
    public required RenderFragment BottomRightChild { get; init; }

    [Parameter]
    public LayoutOrientation Orientation { get; init; } = LayoutOrientation.Horizontal;

    [Parameter]
    public float DefaultRatio { get; init; } = 0.5f;

    private string OrientationClass => Orientation == LayoutOrientation.Horizontal ? "horizontal" : "vertical";
    private string DefaultGridTemplate => GetDefaultGridTemplateStyle();

    private ElementReference _containerElement;
    private IJSObjectReference? _module;


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            _module = await JSRuntime.InvokeAsync<IJSObjectReference>(
                "import", "./_content/TabiSaki.Components/Layout/ResizeableLayoutDivider.razor.js"
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

    private string GetDefaultGridTemplateStyle()
    {
        var percentage = Math.Clamp((int)Math.Round(DefaultRatio * 100.0f), 0, 100);
        var template = $"calc({percentage}% - var(--handle-size)) min-content 1fr;";

        return Orientation == LayoutOrientation.Horizontal ? $"grid-template-columns: {template};" : $"grid-template-rows: {template};";
    }
}