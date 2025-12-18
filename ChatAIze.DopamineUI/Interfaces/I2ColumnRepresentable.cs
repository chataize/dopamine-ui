namespace ChatAIze.DopamineUI.Interfaces;

/// <summary>
/// Represents a data item that can render at least two columns in <see cref="Components.DPTable{T}"/>.
/// </summary>
/// <remarks>
/// <para>Tip: Implement <see cref="I1ColumnRepresentable"/> and return stable, user-friendly strings.</para>
/// <para>Limitation: Only string columns are supported by the built-in table renderer.</para>
/// </remarks>
public interface I2ColumnRepresentable : I1ColumnRepresentable
{
    /// <summary>
    /// Gets the value for the second column.
    /// </summary>
    string Column2 { get; }
}
