namespace ChatAIze.DopamineUI.Interfaces;

/// <summary>
/// Represents a data item that can render at least three columns in <see cref="Components.DPTable{T}"/>.
/// </summary>
/// <remarks>
/// <para>Tip: Implement <see cref="I2ColumnRepresentable"/> to supply the first two columns.</para>
/// <para>Limitation: Only string columns are supported by the built-in table renderer.</para>
/// </remarks>
public interface I3ColumnRepresentable : I2ColumnRepresentable
{
    /// <summary>
    /// Gets the value for the third column.
    /// </summary>
    string Column3 { get; }
}
