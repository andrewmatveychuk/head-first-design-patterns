namespace Chapter12_CompoundPatterns;

public class DuckCall : IQuackable
{
    private readonly Observable observable;

    public DuckCall()
    {
        this.observable = new Observable(this);
    }

    public void NotifyObservers()
    {
        this.observable.NotifyObservers();
    }

    public void Quack()
    {
        System.Console.WriteLine("Kwak");
        this.NotifyObservers();
    }

    public void RegisterObserver(IQuackObserver observer)
    {
        this.observable.RegisterObserver(observer);
    }

    public override string ToString()
    {
        return "Duck Call";
    }
}
