namespace Chapter12_CompoundPatterns;

public class RedheadDuck : IQuackable
{
    private readonly Observable observable;

    public RedheadDuck()
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
        return "Redhead Duck";
    }
}
