namespace Chapter12_CompoundPatterns;

public interface IQuackObservable
{
    public void RegisterObserver(IQuackObserver observer);

    public void NotifyObservers();
}
