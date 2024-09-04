namespace Chapter12_CompoundPatterns;

public abstract class AbstractDuckFactory
{
    public abstract IQuackable CreateMallardDuck();
    public abstract IQuackable CreateRedheadDuck();
    public abstract IQuackable CreateDuckCall();
    public abstract IQuackable CreateRubberDuck();
}
