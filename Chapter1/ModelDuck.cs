using Ducks;
using System.Diagnostics.CodeAnalysis;

class ModelDuck : Duck
{
    [SetsRequiredMembers]
    public ModelDuck() : base(new FlyNoWay(), new Quack()) { }

    [SetsRequiredMembers]
    public ModelDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) : base(flyBehavior, quackBehavior) { }

    public override void Display() => Console.WriteLine("I'm a model duck.");
}