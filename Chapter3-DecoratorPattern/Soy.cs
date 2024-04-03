namespace StarbuzzCoffee;
using System.Diagnostics.CodeAnalysis;
public class Soy : CondimentDecorator
{
    [SetsRequiredMembers]
    public Soy(Beverage beverage) => base.Beverage = beverage;

    public override string Description => base.Beverage.Description + ", Soy";

    public override decimal Cost => Size switch
    {
        BeverageSize.TALL => base.Beverage.Cost + 0.10M,
        BeverageSize.GRANDE => base.Beverage.Cost + 0.15M,
        BeverageSize.VENTI => base.Beverage.Cost + 0.20M,
        _ => throw new ArgumentOutOfRangeException(nameof(Size), $"Not expected size value: {Size}"),
    };

}