using Ducks;
using System.Diagnostics.CodeAnalysis;

class ModelDuck : Duck
{
    [SetsRequiredMembers]
    public ModelDuck()
    {
        base.FlyBehavior = new FlyNoWay();
        base.QuackBehavior = new Quack();
    }

    public override void Display() => Console.WriteLine("I'm a model duck.");
}