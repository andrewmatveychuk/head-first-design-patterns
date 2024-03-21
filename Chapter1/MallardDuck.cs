using Ducks;
using System.Diagnostics.CodeAnalysis;

public class MallardDuck : Duck
{
    [SetsRequiredMembers]
    public MallardDuck()
    {
        base.FlyBehavior = new FlyWithWings();
        base.QuackBehavior = new Quack();
    }

    public override void Display() => Console.WriteLine("I'm a real Mallard duck.");
}