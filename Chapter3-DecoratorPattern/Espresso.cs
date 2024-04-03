namespace StarbuzzCoffee;
using System.Diagnostics.CodeAnalysis;

public class Espresso : Beverage
{
    [SetsRequiredMembers]
    public Espresso(BeverageSize size) => base.Size = size;

    public override string Description => "Espresso";

    public override decimal Cost => Size switch
    {
        BeverageSize.TALL => 1.79M,
        BeverageSize.GRANDE => 1.99M,
        BeverageSize.VENTI => 2.19M,
        _ => throw new ArgumentOutOfRangeException(nameof(Size), $"Not expected size value: {Size}"),
    };
}