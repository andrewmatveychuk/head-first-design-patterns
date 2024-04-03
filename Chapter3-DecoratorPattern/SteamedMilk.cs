namespace StarbuzzCoffee;

public class SteamedMilk : CondimentDecorator
{
    public override string Description => base.Beverage.Description + ", Steamed Milk";

    public override decimal Cost => Size switch
    {
        BeverageSize.TALL => base.Beverage.Cost + 0.5M,
        BeverageSize.GRANDE => base.Beverage.Cost + 0.10M,
        BeverageSize.VENTI => base.Beverage.Cost + 0.15M,
        _ => throw new ArgumentOutOfRangeException(nameof(Size), $"Not expected size value: {Size}"),
    };
}