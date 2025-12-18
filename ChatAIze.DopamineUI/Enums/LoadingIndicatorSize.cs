namespace ChatAIze.DopamineUI.Enums;

/// <summary>
/// Defines the size options for <see cref="Components.DPLoadingIndicator"/>.
/// </summary>
/// <remarks>
/// Sizes map to 24, 32, and 48 pixel assets in the embedded loading GIFs.
/// </remarks>
public enum LoadingIndicatorSize
{
    /// <summary>
    /// A compact indicator, suitable for inline loading states.
    /// </summary>
    Small,
    /// <summary>
    /// The default indicator size.
    /// </summary>
    Medium,
    /// <summary>
    /// A prominent indicator, suitable for overlays or blocking states.
    /// </summary>
    Large
}
