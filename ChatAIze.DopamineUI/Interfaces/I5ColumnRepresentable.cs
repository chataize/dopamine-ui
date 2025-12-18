namespace ChatAIze.DopamineUI.Interfaces;

/// <summary>
/// Represents a data item that can render up to five columns in <see cref="Components.DPTable{T}"/>.
/// </summary>
/// <remarks>
/// <para>Tip: Implement <see cref="I4ColumnRepresentable"/> to supply the first four columns.</para>
/// <para>Limitation: Only string columns are supported by the built-in table renderer.</para>
/// </remarks>
public interface I5ColumnRepresentable : I4ColumnRepresentable
{
    /// <summary>
    /// Gets the value for the fifth column.
    /// </summary>
    string Column5 { get; }
}
