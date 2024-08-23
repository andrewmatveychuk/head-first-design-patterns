namespace GumballMachineWithState;

public class SoldState : IGumballMachineState
{
    private GumballMachine gumballMachine;

    public SoldState(GumballMachine gumballMachine)
    {
        this.gumballMachine = gumballMachine;
    }

    public void InsertQuarter()
    {
        System.Console.WriteLine("Please wait, we're already giving you a gumball");
    }

    public void EjectQuarter()
    {
        System.Console.WriteLine("Sorry, you already turned the crank");
    }

    public void TurnCrank()
    {
        System.Console.WriteLine("Turning twice doesn't get you another gumball!");
    }

    public void Dispense()
    {
        this.gumballMachine.ReleaseBall();
        if (this.gumballMachine.CountOfGumballs > 0)
        {
            this.gumballMachine.State = this.gumballMachine.NoQuarterState;
        }
        else
        {
            System.Console.WriteLine("Oops, out of gumballs!");
            this.gumballMachine.State = this.gumballMachine.SoldOutState;
        }
    }

    public void Refill(int numberOfGumBalls) { }

    public override string ToString()
    {
        return "dispensing a gumball";
    }
}
