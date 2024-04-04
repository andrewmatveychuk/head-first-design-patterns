namespace PizzaShop;

public class SimplePizzaFactory
{
    public Pizza CreatePizza(string pizzaType) => pizzaType switch
    {
        "cheese" => new CheesePizza(),
        // "pepperoni" => new PepperoniPizza(),
        // "clam" => new ClamPizza(),
        // "veggie" => new VeggiePizza(),
        _ => throw new ArgumentOutOfRangeException(nameof(pizzaType), $"Not expected pizza type: {pizzaType}"),
    };

}