namespace Chapter12_CompoundPatterns;

public class RubberDuck : IQuackable
{
    private readonly Observable observable;

    public RubberDuck()
    {
        this.observable = new Observable(this);
    }

    public void NotifyObservers()
    {
        this.observable.NotifyObservers();
    }

    public void Quack()
    {
        System.Console.WriteLine("Squeak");
        this.NotifyObservers();
    }

    public void RegisterObserver(IQuackObserver observer)
    {
        this.observable.RegisterObserver(observer);
    }

    public override string ToString()
    {
        return "Rubber Duck";
    }
}
