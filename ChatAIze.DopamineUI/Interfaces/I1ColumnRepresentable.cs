namespace ChatAIze.DopamineUI.Interfaces;

/// <summary>
/// Represents a data item that can render at least one column in <see cref="Components.DPTable{T}"/>.
/// </summary>
/// <remarks>
/// <para>Tip: Return display-ready text; the table renders these values as plain text.</para>
/// <para>Limitation: Only string columns are supported by the built-in table renderer.</para>
/// </remarks>
public interface I1ColumnRepresentable
{
    /// <summary>
    /// Gets the value for the first column.
    /// </summary>
    string Column1 { get; }
}
