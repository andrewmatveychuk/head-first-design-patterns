namespace Chapter12_CompoundPatterns;

public interface IQuackObserver
{
    public void Update(IQuackObservable duck);
}
