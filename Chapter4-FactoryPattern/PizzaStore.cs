namespace PizzaShop;

public abstract class PizzaStore
{
    // private SimplePizzaFactory factory;

    /* public PizzaStore(SimplePizzaFactory factory)
    {
        this.factory = factory;
    } */

    public Pizza OrderPizza(string pizzaType)
    {
        Pizza pizza = CreatePizza(pizzaType);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;

    }

    protected abstract Pizza CreatePizza(string pizzaType);
}