namespace StarbuzzCoffee;
using System.Diagnostics.CodeAnalysis;

public class HouseBlend : Beverage
{
    [SetsRequiredMembers]
    public HouseBlend(BeverageSize size) => base.Size = size;

    public override string Description => "House Blend Coffee";

    public override decimal Cost => Size switch
    {
        BeverageSize.TALL => 0.69M,
        BeverageSize.GRANDE => 0.89M,
        BeverageSize.VENTI => 1.09M,
        _ => throw new ArgumentOutOfRangeException(nameof(Size), $"Not expected size value: {Size}"),
    };
}