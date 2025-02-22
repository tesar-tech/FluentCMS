namespace FluentCMS.Web.UI.Components;

public partial class Button
{
    [Parameter]
    [CSSProperty]
    public bool Block { get; set; }

    [Parameter]
    [CSSProperty]
    public Color Color { get; set; } = Color.Default;

    [Parameter]
    [CSSProperty]
    public bool Disabled { get; set; }

    [Parameter]
    [CSSProperty]
    public bool Ghost { get; set; }

    [Parameter]
    public string? Href { get; set; }

    [Parameter]
    [CSSProperty]
    public bool Link { get; set; }

    [Parameter]
    [CSSProperty]
    public bool Outline { get; set; }

    [Parameter]
    [CSSProperty]
    public ButtonSize Size { get; set; } = ButtonSize.Medium;

    [Parameter]
    public ButtonType Type { get; set; } = ButtonType.Button;

    [Parameter]
    public RenderFragment ChildContent { get; set; } = default!;
}
