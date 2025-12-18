namespace ChatAIze.DopamineUI.Interfaces;

/// <summary>
/// Represents a data item that can render at least four columns in <see cref="Components.DPTable{T}"/>.
/// </summary>
/// <remarks>
/// <para>Tip: Implement <see cref="I3ColumnRepresentable"/> to supply the first three columns.</para>
/// <para>Limitation: Only string columns are supported by the built-in table renderer.</para>
/// </remarks>
public interface I4ColumnRepresentable : I3ColumnRepresentable
{
    /// <summary>
    /// Gets the value for the fourth column.
    /// </summary>
    string Column4 { get; }
}
