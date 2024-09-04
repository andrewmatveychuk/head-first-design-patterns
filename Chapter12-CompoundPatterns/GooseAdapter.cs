namespace Chapter12_CompoundPatterns;

public class GooseAdapter : IQuackable
{
    private readonly Goose goose;
    private readonly Observable observable;

    public GooseAdapter(Goose goose)
    {
        this.observable = new Observable(this);
        this.goose = goose;
    }

    public void NotifyObservers()
    {
        this.observable.NotifyObservers();
    }

    public void Quack()
    {
        this.goose.Honk();
        this.NotifyObservers();
    }

    public void RegisterObserver(IQuackObserver observer)
    {
        this.observable.RegisterObserver(observer);
    }

    public override string ToString()
    {
        return "Goose pretending to be a Duck";
    }
}
