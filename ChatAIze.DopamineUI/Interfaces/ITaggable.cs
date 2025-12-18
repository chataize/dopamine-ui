namespace ChatAIze.DopamineUI.Interfaces;

/// <summary>
/// Provides a place to attach arbitrary user data to a component.
/// </summary>
/// <remarks>
/// <para>Tip: Use <see cref="Tag"/> for view models, IDs, or metadata you do not want to render.</para>
/// <para>Limitation: The Dopamine UI components do not read or mutate this value.</para>
/// </remarks>
public interface ITaggable
{
    /// <summary>
    /// Gets or sets the associated user data.
    /// </summary>
    public object? Tag { get; set; }
}
