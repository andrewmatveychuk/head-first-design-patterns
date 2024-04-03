namespace StarbuzzCoffee;
using System.Diagnostics.CodeAnalysis;

public class Mocha : CondimentDecorator
{
    [SetsRequiredMembers]
    public Mocha(Beverage beverage) => base.Beverage = beverage;

    public override string Description => base.Beverage.Description + ", Mocha";

    public override decimal Cost => Size switch
    {
        BeverageSize.TALL => base.Beverage.Cost + 0.10M,
        BeverageSize.GRANDE => base.Beverage.Cost + 0.20M,
        BeverageSize.VENTI => base.Beverage.Cost + 0.30M,
        _ => throw new ArgumentOutOfRangeException(nameof(Size), $"Not expected size value: {Size}"),
    };
}