namespace ChatAIze.DopamineUI.Enums;

/// <summary>
/// Defines responsive breakpoints used by Dopamine UI layout components.
/// </summary>
/// <remarks>
/// Values map to Tailwind breakpoints: <c>sm</c>, <c>md</c>, <c>lg</c>, <c>xl</c>, and <c>2xl</c>. <see cref="ExtraSmall"/> represents the base (no prefix).
/// </remarks>
public enum ScreenSize
{
    /// <summary>
    /// The base breakpoint (no prefix).
    /// </summary>
    ExtraSmall,

    /// <summary>
    /// The small breakpoint (<c>sm</c>).
    /// </summary>
    Small,

    /// <summary>
    /// The medium breakpoint (<c>md</c>).
    /// </summary>
    Medium,

    /// <summary>
    /// The large breakpoint (<c>lg</c>).
    /// </summary>
    Large,

    /// <summary>
    /// The extra large breakpoint (<c>xl</c>).
    /// </summary>
    ExtraLarge,

    /// <summary>
    /// The double extra large breakpoint (<c>2xl</c>).
    /// </summary>
    ExtraExtraLarge
}
