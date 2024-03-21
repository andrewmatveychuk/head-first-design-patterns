using Ducks;
using System.Diagnostics.CodeAnalysis;

public class MallardDuck : Duck
{
    [SetsRequiredMembers]
    public MallardDuck() : base(new FlyWithWings(), new Quack()) { }

    [SetsRequiredMembers]
    public MallardDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) : base(flyBehavior, quackBehavior) { }

    public override void Display() => Console.WriteLine("I'm a real Mallard duck.");
}