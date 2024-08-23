namespace GumballMachineWithState;

public class HasQuarterState : IGumballMachineState
{
    private GumballMachine gumballMachine;

    public HasQuarterState(GumballMachine gumballMachine)
    {
        this.gumballMachine = gumballMachine;
    }

    public void InsertQuarter()
    {
        System.Console.WriteLine("You can't insert another quarter");
    }

    public void EjectQuarter()
    {
        System.Console.WriteLine("Quarter returned");
        this.gumballMachine.State = this.gumballMachine.NoQuarterState;
    }

    public void TurnCrank()
    {
        System.Console.WriteLine("You turned...");
        this.gumballMachine.State = this.gumballMachine.SoldState;
    }

    public void Dispense()
    {
        System.Console.WriteLine("No gumball dispensed");
    }

    public void Refill(int numberOfGumBalls) { }

    public override string ToString()
    {
        return "waiting for turn of crank";
    }

}
