namespace Ducks;

public abstract class Duck
{
    public required IFlyBehavior FlyBehavior { get; set; }
    public required IQuackBehavior QuackBehavior { get; set; }

    public Duck() { }

    public void PerformFly() => FlyBehavior.Fly();

    public void PerformQuack() => QuackBehavior.Quack();

    public void Swim() => Console.WriteLine("All ducks float.");

    public virtual void Display() => Console.WriteLine("I'm a duck.");
}