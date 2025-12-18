using ChatAIze.DopamineUI.Components;

namespace ChatAIze.DopamineUI;

/// <summary>
/// Represents the cascading context used by Dopamine UI components to coordinate navigation, tabs, menus, and disabled state.
/// </summary>
/// <remarks>
/// <para>Tip: You typically do not instantiate this directly; container components populate it for their children.</para>
/// <para>Warning: Components treat <see cref="IsDisabled"/> as authoritative and will suppress interactions and callbacks.</para>
/// </remarks>
public sealed record UIContext
{
    /// <summary>
    /// Gets the active navigation view for navigation-aware components.
    /// </summary>
    /// <remarks>
    /// This is set by <see cref="Components.DPNavigationView"/> and used by navigation title and link components.
    /// </remarks>
    public DPNavigationView? NavigationView { get; init; }

    /// <summary>
    /// Gets the active tab view for tabs to register with.
    /// </summary>
    /// <remarks>
    /// This is set by <see cref="Components.DPTabView"/> and consumed by <see cref="Components.DPTab"/>.
    /// </remarks>
    public DPTabView? TabView { get; init; }

    /// <summary>
    /// Gets the active menu instance for menu items to coordinate with.
    /// </summary>
    /// <remarks>
    /// This is set by <see cref="Components.DPMenu"/> and used by <see cref="Components.DPMenuItem"/> to close menus.
    /// </remarks>
    public DPMenu? Menu { get; init; }

    /// <summary>
    /// Gets a value indicating whether the current UI subtree is disabled.
    /// </summary>
    /// <remarks>
    /// When true, components should render disabled styling and avoid raising events.
    /// </remarks>
    public bool IsDisabled { get; init; }
}
