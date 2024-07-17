using ChatAIze.DopamineUI.Interfaces;

namespace ChatAIze.DopamineUI.Preview.Models;

public record StoreItem(string Name, string Price, int Quantity) : I3ColumnRepresentable
{
    public string Column1 => Name;

    public string Column2 => Price;

    public string Column3 => Quantity.ToString();
}
