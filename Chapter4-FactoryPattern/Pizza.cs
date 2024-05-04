namespace PizzaShop;
using System.Diagnostics.CodeAnalysis;
public abstract class Pizza
{
    public required string Name { get; init; }

    //Replaced to use the ingredient factories
    /* public required string Dough { get; init;}
    public required string Sauce { get; init;}
    public List<string> Toppings = []; */

    protected IDough? dough;
    protected ISauce? sauce;
    protected ICheese? cheese;
    protected IPepperoni? pepperoni;
    protected IClams? clams;
    protected List<IVeggie>? veggies;


    internal void Bake() => Console.WriteLine("Baking for 25 minutes at 350...");

    internal void Box() => Console.WriteLine("Placing the pizza in a PizzaStore box...");

    internal void Cut() => Console.WriteLine("Cutting the pizza into diagonal slices...");

    //Replaced to use the ingredient factories
    /* internal void Prepare()
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
    } */


    internal abstract void Prepare();
}

public class CheesePizza : Pizza
{
    IPizzaIngredientFactory ingredientFactory;

    [SetsRequiredMembers]
    public CheesePizza(IPizzaIngredientFactory ingredientFactory, string name)
    {
        this.ingredientFactory = ingredientFactory;
        this.Name = name;
    }

    internal override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        dough = ingredientFactory.CreateDough();
        sauce = ingredientFactory.CreateSauce();
        cheese = ingredientFactory.CreateCheese();
        Console.WriteLine("Ingredients:");
        Console.WriteLine($"{dough.Name}");
        Console.WriteLine($"{sauce.Name}");
        Console.WriteLine($"{cheese.Name}");
    }
}

/* public class NYStyleCheesePizza : Pizza
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
} */

public class ClamPizza : Pizza
{
    IPizzaIngredientFactory ingredientFactory;

    [SetsRequiredMembers]
    public ClamPizza(IPizzaIngredientFactory ingredientFactory, string name)
    {
        this.ingredientFactory = ingredientFactory;
        this.Name = name;
    }

    internal override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        dough = ingredientFactory.CreateDough();
        sauce = ingredientFactory.CreateSauce();
        cheese = ingredientFactory.CreateCheese();
        clams = ingredientFactory.CreateClam();
        Console.WriteLine("Ingredients:");
        Console.WriteLine($"{dough.Name}");
        Console.WriteLine($"{sauce.Name}");
        Console.WriteLine($"{cheese.Name}");
        Console.WriteLine($"{clams.Name}");
    }
}