namespace GumballMachineWithState;

internal class HasQuarterState : IGumballMachineState
{
    private readonly GumballMachine gumballMachine;
    private readonly Random randomWinner = Random.Shared;

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
        int winner = this.randomWinner.Next(10);
        if (winner == 0 && this.gumballMachine.CountOfGumballs > 1)
        {
            this.gumballMachine.State = this.gumballMachine.WinnerState;
        }
        else
        {
            this.gumballMachine.State = this.gumballMachine.SoldState;
        }
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
