using System.Security.Claims;

namespace PizzaShop;

public interface IPizzaIngredientFactory
{
    public IDough CreateDough();
    public ISauce CreateSauce();
    public ICheese CreateCheese();
    public List<IVeggie> CreateVeggies();
    public IPepperoni CreatePepperoni();
    public IClams CreateClam();
}
