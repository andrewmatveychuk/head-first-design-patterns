namespace PizzaShop;

public class ChicagoStylePizzaStore : PizzaStore
{
    IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

    protected override Pizza CreatePizza(string pizzaType) => pizzaType switch
    {
        "cheese" => new CheesePizza(ingredientFactory, "Chicago Style Cheese Pizza"),
        // "pepperoni" => new PepperoniPizza(),
        "clam" => new ClamPizza(ingredientFactory, "Chicago Style Clam Pizza"),
        // "veggie" => new VeggiePizza(),
        _ => throw new ArgumentOutOfRangeException(nameof(pizzaType), $"Not expected pizza type: {pizzaType}"),
    };
}