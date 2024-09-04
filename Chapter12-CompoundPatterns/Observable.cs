
namespace Chapter12_CompoundPatterns;

public class Observable(IQuackable duck) : IQuackObservable
{
    private readonly List<IQuackObserver> observers = [];

    private readonly IQuackable duck = duck;

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(duck);
        }
    }

    public void RegisterObserver(IQuackObserver observer)
    {
        this.observers.Add(observer);
    }
}
