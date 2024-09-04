namespace GumballMachineWithState;

internal class NoQuarterState : IGumballMachineState
{
    private readonly GumballMachine gumballMachine;

    public NoQuarterState(GumballMachine gumballMachine)
    {
        this.gumballMachine = gumballMachine;
    }

    public void InsertQuarter()
    {
        System.Console.WriteLine("You inserted a quarter");
        this.gumballMachine.State = this.gumballMachine.HasQuarterState;
    }

    public void EjectQuarter()
    {
        System.Console.WriteLine("You haven't inserted a quarter");
    }

    public void TurnCrank()
    {
        System.Console.WriteLine("You turned, but there's no quarter");
    }

    public void Dispense()
    {
        System.Console.WriteLine("You need to pay first");
    }

    public void Refill(int numberOfGumBalls) { }

    public override string ToString()
    {
        return "waiting for quarter";
    }
}
