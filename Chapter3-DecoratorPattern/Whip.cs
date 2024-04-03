namespace StarbuzzCoffee;
using System.Diagnostics.CodeAnalysis;
public class Whip : CondimentDecorator
{
    [SetsRequiredMembers]
    public Whip(Beverage beverage) => base.Beverage = beverage;

    public override string Description => base.Beverage.Description + ", Whip";

    public override decimal Cost => Size switch
    {
        BeverageSize.TALL => base.Beverage.Cost + 0.5M,
        BeverageSize.GRANDE => base.Beverage.Cost + 0.10M,
        BeverageSize.VENTI => base.Beverage.Cost + 0.15M,
        _ => throw new ArgumentOutOfRangeException(nameof(Size), $"Not expected size value: {Size}"),
    };
}