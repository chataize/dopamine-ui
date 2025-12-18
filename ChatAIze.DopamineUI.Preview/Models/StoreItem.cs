using ChatAIze.DopamineUI.Interfaces;

namespace ChatAIze.DopamineUI.Preview.Models;

/// <summary>
/// Sample model used by the preview app to demonstrate table rendering.
/// </summary>
/// <param name="Name">The display name of the item.</param>
/// <param name="Price">The formatted price string.</param>
/// <param name="Quantity">The numeric quantity available.</param>
/// <remarks>
/// This type implements <see cref="I3ColumnRepresentable"/> so it can be displayed by <see cref="Components.DPTable{T}"/>.
/// </remarks>
public record StoreItem(string Name, string Price, int Quantity) : I3ColumnRepresentable
{
    /// <summary>
    /// Gets the first column value (name).
    /// </summary>
    public string Column1 => Name;

    /// <summary>
    /// Gets the second column value (price).
    /// </summary>
    public string Column2 => Price;

    /// <summary>
    /// Gets the third column value (quantity).
    /// </summary>
    public string Column3 => Quantity.ToString();
}
