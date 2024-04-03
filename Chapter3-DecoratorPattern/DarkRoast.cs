namespace StarbuzzCoffee;
using System.Diagnostics.CodeAnalysis;

public class DarkRoast : Beverage
{
    [SetsRequiredMembers]
    public DarkRoast(BeverageSize size) => base.Size = size;

    public override string Description => "Dark Roast";

    public override decimal Cost => Size switch
    {
        BeverageSize.TALL => 0.78M,
        BeverageSize.GRANDE => 0.99M,
        BeverageSize.VENTI => 1.19M,
        _ => throw new ArgumentOutOfRangeException(nameof(Size), $"Not expected size value: {Size}"),
    };
}