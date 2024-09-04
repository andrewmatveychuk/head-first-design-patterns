
namespace Chapter12_CompoundPatterns;

public class MallardDuck : IQuackable
{
    private readonly Observable observable;

    public MallardDuck()
    {
        this.observable = new Observable(this);
    }

    public void NotifyObservers()
    {
        this.observable.NotifyObservers();
    }

    public void Quack()
    {
        System.Console.WriteLine("Quack");
        this.NotifyObservers();
    }

    public void RegisterObserver(IQuackObserver observer)
    {
        this.observable.RegisterObserver(observer);
    }

    public override string ToString()
    {
        return "Mallard Duck";
    }
}
