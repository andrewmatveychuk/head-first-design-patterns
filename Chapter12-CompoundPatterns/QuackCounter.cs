namespace Chapter12_CompoundPatterns;

public class QuackCounter(IQuackable duck) : IQuackable
{
    private readonly IQuackable duck = duck;

    public static int NumberOfQuacks { get; private set; }

    public void NotifyObservers()
    {
        this.duck.NotifyObservers();
    }

    public void Quack()
    {
        this.duck.Quack();
        QuackCounter.NumberOfQuacks++;
    }

    public void RegisterObserver(IQuackObserver observer)
    {
        this.duck.RegisterObserver(observer);
    }

    public override string ToString()
    {
        return this.duck.ToString();
    }
}
