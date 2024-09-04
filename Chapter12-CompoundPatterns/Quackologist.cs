namespace Chapter12_CompoundPatterns;

public class Quackologist : IQuackObserver
{
    public void Update(IQuackObservable duck)
    {
        System.Console.WriteLine($"Quackologist: {duck} just quacked.");
    }
}
