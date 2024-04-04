namespace PizzaShop;

public class ChicagoStylePizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string pizzaType)=> pizzaType switch
    {
        "cheese" => new ChicagoStyleCheesePizza(),
        // "pepperoni" => new ChicagoStylePepperoniPizza(),
        // "clam" => new ChicagoStyleClamPizza(),
        // "veggie" => new ChicagoStyleVeggiePizza(),
        _ => throw new ArgumentOutOfRangeException(nameof(pizzaType), $"Not expected pizza type: {pizzaType}"),
    };
}