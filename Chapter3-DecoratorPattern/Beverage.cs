namespace StarbuzzCoffee;

public abstract class Beverage
{
    public abstract string Description { get; }

    public abstract decimal Cost { get; }

    public required BeverageSize Size;
}