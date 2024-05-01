using System.Net.Http.Headers;

namespace PizzaShop;

public class NYPizzaIngredientFactory : IPizzaIngredientFactory
{
    public ICheese CreateCheese()
    {
        return new ReggianoCheese();
    }

    public IClams CreateClam()
    {
        return new FreshClams();
    }

    public IDough CreateDough()
    {
        return new ThinCrustDough();
    }

    public IPepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public ISauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public List<IVeggie> CreateVeggies()
    {
        return [new Garlic(), new Onion(), new Mushroom(), new RedPepper()];
    }
}
