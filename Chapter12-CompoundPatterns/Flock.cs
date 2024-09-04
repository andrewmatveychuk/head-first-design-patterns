namespace Chapter12_CompoundPatterns;

public class Flock : IQuackable
{

    private readonly Observable observable;
    private readonly List<IQuackable> quackers = [];


    public Flock()
    {
        this.observable = new Observable(this);
    }

    public void Add(IQuackable quacker)
    {
        quackers.Add(quacker);
    }

    public void NotifyObservers(){}

    public void Quack()
    {
        foreach (var quacker in this.quackers)
        {
            quacker.Quack();
        }
    }

    public void RegisterObserver(IQuackObserver observer)
    {
        foreach (var quacker in this.quackers)
        {
            quacker.RegisterObserver(observer);
        }
    }

    public override string ToString()
    {
        return "Flock of ducks";
    }
}
