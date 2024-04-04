namespace PizzaShop;

public class NYStylePizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string pizzaType)=> pizzaType switch
    {
        "cheese" => new NYStyleCheesePizza(),
        // "pepperoni" => new NYStylePepperoniPizza(),
        // "clam" => new NYStyleClamPizza(),
        // "veggie" => new NYStyleVeggiePizza(),
        _ => throw new ArgumentOutOfRangeException(nameof(pizzaType), $"Not expected pizza type: {pizzaType}"),
    };
}