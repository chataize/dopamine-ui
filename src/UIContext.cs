using ChatAIze.DopamineUI.Components;

namespace ChatAIze.DopamineUI;

public sealed record UIContext
{
    public DPNavigationView? NavigationView { get; init; }

    public DPTabView? TabView { get; init; }

    public DPMenu? Menu { get; init; }

    public bool IsDisabled { get; init; }
}
