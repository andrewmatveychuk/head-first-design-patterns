namespace ObjectvilleCafe;

public class MenuItem(string name, string description, double price, bool isVegetarian)
{
    public string Name { get; } = name;
    public string Description { get; } = description;
    public bool IsVegetarian { get; } = isVegetarian;
    public double Price { get; } = price;
}
