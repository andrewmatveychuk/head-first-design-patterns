namespace GumballMachineWithState;

public class WinnerState : IGumballMachineState
{
    private readonly GumballMachine gumballMachine;

    public WinnerState(GumballMachine gumballMachine)
    {
        this.gumballMachine = gumballMachine;
    }
    public void InsertQuarter()
    {
        System.Console.WriteLine("Please wait, we're already giving you a Gumball");
    }

    public void EjectQuarter()
    {
        System.Console.WriteLine("Please wait, we're already giving you a Gumball");
    }

    public void TurnCrank()
    {
        System.Console.WriteLine("Turning again doesn't get you another gumball!");
    }

    public void Dispense()
    {
        this.gumballMachine.ReleaseBall();
        if (this.gumballMachine.CountOfGumballs == 0)
        {
            this.gumballMachine.State = this.gumballMachine.SoldOutState;
        }
        else
        {
            this.gumballMachine.ReleaseBall();
            System.Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter");
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
    }

    public void Refill(int numberOfGumBalls) { }

    public override string ToString()
    {
        return "despensing two gumballs for your quarter, because YOU'RE A WINNER!";
    }
}
