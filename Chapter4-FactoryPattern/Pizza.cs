namespace PizzaShop;
using System.Diagnostics.CodeAnalysis;
public abstract class Pizza
{
    public required string Name { get; init; }
    public required string Dough { get; init;}
    public required string Sauce { get; init;}
    public List<string> Toppings = [];

    internal void Bake() => Console.WriteLine("Baking for 25 minutes at 350...");

    internal void Box() => Console.WriteLine("Placing the pizza in a PizzaStore box...");

    internal void Cut() => Console.WriteLine("Cutting the pizza into diagonal slices...");

    internal void Prepare()
    {
        Console.WriteLine($"Preparing {Name}:");
        Console.WriteLine($"Tossing dough: {Dough}");
        Console.WriteLine($"Adding sauce: {Sauce}");
        Console.WriteLine("Adding toppings:");
        foreach (var topping in Toppings)
        {
            Console.Write($"\t{topping}");
        }
        Console.WriteLine();
    }
}

public class CheesePizza : Pizza
{
    [SetsRequiredMembers]
    public CheesePizza()
    {
        Name = "Cheese Pizza";
        Dough = "Dough";
        Sauce = "Sauce";
        Toppings.Add("Cheese");
    }
}

public class NYStyleCheesePizza : Pizza
{
    [SetsRequiredMembers]
    public NYStyleCheesePizza()
    {
        Name = "NY Style Sauce and Cheese Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";
        Toppings.Add("Grated Reggiano Cheese");
    }
}

public class ChicagoStyleCheesePizza : Pizza
{
    [SetsRequiredMembers]
    public ChicagoStyleCheesePizza()
    {
        Name = "Chicago Style Deep Dish Cheese Pizza";
        Dough = "Extra Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";
        Toppings.Add("Shredded Mozzarella Cheese");
    }
}