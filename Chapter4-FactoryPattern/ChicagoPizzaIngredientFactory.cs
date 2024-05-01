namespace PizzaShop;

public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
{
    public ICheese CreateCheese()
    {
        return new MozzarellaCheese();
    }

    public IClams CreateClam()
    {
        return new FrozenClams();
    }

    public IDough CreateDough()
    {
        return new ThickCrustDough();
    }

    public IPepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public ISauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public List<IVeggie> CreateVeggies()
    {
        return [new Spinach(), new BlackOlives(), new Eggplant()];
    }
}
