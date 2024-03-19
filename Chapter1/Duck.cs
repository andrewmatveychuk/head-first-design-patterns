namespace Ducks;

class Duck
{
    IFlyBehavior? flyBehavior;
    IQuackBehavior? quackBehavior;

    public Duck() { }

    public void PerformFly () {
        flyBehavior.Fly();
    }

    public void PerformQuack() {
        quackBehavior.Quack();
    }

    public void Swim() {
        System.Console.WriteLine("All ducks float.");
    }
}