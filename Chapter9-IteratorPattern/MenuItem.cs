namespace ObjectvilleCafe;

public class MenuItem : MenuComponent
{
    private string name;
    private string description;
    private double price;
    private bool isVegetarian;

    public override string Name { get => name; set => name = value; }
    public override string Description { get => description; set => description = value; }
    public override double Price { get => price; set => price = value; }
    public override bool IsVegetarian { get => isVegetarian; set => isVegetarian = value; }

    public MenuItem(string name, string description, double price, bool isVegetarian)
    {
        this.name = name;
        this.description = description;
        this.price = price;
        this.isVegetarian = isVegetarian;
    }

    public override void Print()
    {
        string vegetarian;
        if (IsVegetarian)
        {
            vegetarian = "Veg";
        }
        else
        {
            vegetarian = "NonVeg";
        }
        System.Console.WriteLine($"{Name}, {Price:C}, {vegetarian}, {Description}");
    }
}
