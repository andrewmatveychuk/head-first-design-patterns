namespace PizzaShop;

public interface IPizzaIngredient
{
    string Name { get; }
}
public interface IDough : IPizzaIngredient { }
public interface ISauce : IPizzaIngredient { }
public interface ICheese : IPizzaIngredient { }
public interface IClams : IPizzaIngredient { }
public interface IPepperoni : IPizzaIngredient { }
public interface IVeggie : IPizzaIngredient { }

public class ReggianoCheese : ICheese
{
    public string Name => "Reggiano Cheese";
}

public class FreshClams : IClams
{
    public string Name => "Fresh Clams";
}

public class ThinCrustDough : IDough
{
    public string Name => "Thin Crust Dough";
}

public class SlicedPepperoni : IPepperoni
{
    public string Name => "Sliced Pepperoni";
}

public class MarinaraSauce : ISauce
{
    public string Name => "Marinara Sauce";
}

public class MozzarellaCheese : ICheese
{
    public string Name => "Mozzarella Cheese";
}

public class FrozenClams : IClams
{
    public string Name => "Frozen Clams";
}

public class ThickCrustDough : IDough
{
    public string Name => "Thick Crust Dough";
}

public class PlumTomatoSauce : ISauce
{
    public string Name => "Plum Tomato Sauce";
}

public class Garlic : IVeggie
{
    public string Name => "Garlic";
}
public class Onion : IVeggie
{
    public string Name => "Onion";
}
public class Mushroom : IVeggie
{
    public string Name => "Mushroom";
}
public class RedPepper : IVeggie
{
    public string Name => "Red Pepper";
}
public class Spinach : IVeggie
{
    public string Name => "Spinach";
}
public class Eggplant : IVeggie
{
    public string Name => "Eggplant";
}
public class BlackOlives : IVeggie
{
    public string Name => "Black Olives";
}