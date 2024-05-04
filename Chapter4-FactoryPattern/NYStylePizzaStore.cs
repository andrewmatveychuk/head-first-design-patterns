namespace PizzaShop;

public class NYStylePizzaStore : PizzaStore
{
    IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
    protected override Pizza CreatePizza(string pizzaType)=> pizzaType switch
    {
        "cheese" => new CheesePizza(ingredientFactory, "New York Style Cheese Pizza"),
        // "pepperoni" => new PepperoniPizza(),
        "clam" => new ClamPizza(ingredientFactory, "New Your Style Clam Pizza"),
        // "veggie" => new VeggiePizza(),
        _ => throw new ArgumentOutOfRangeException(nameof(pizzaType), $"Not expected pizza type: {pizzaType}"),
    };
}