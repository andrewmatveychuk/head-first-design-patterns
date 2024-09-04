using System.Text;

namespace GumballMachineWithState;

public class GumballMachine
{
    public IGumballMachineState HasQuarterState { get; }
    public IGumballMachineState NoQuarterState { get; }
    public IGumballMachineState SoldOutState { get; }
    public IGumballMachineState SoldState { get; }
    public IGumballMachineState WinnerState { get; }

    public IGumballMachineState State { get; internal set; }
    public int CountOfGumballs { get; private set; } = 0;
    public string Location { get; }

    public GumballMachine(int numberOfGumballs, string location)
    {
        this.Location = location;
        this.SoldOutState = new SoldOutState(this);
        this.NoQuarterState = new NoQuarterState(this);
        this.HasQuarterState = new HasQuarterState(this);
        this.SoldState = new SoldState(this);
        this.WinnerState = new WinnerState(this);

        this.CountOfGumballs = numberOfGumballs;
        if (this.CountOfGumballs > 0)
        {
            this.State = this.NoQuarterState;
        }
        else
        {
            this.State = this.SoldOutState;
        }
    }
    public void InsertQuarter()
    {
        this.State.InsertQuarter();
    }
    public void EjectQuarter()
    {
        this.State.EjectQuarter();
    }

    public void TurnCrank()
    {
        this.State.TurnCrank();
        this.State.Dispense();
    }


    private void Refill(int numberOfGumBalls)
    {
        this.CountOfGumballs += numberOfGumBalls;
        this.State.Refill(numberOfGumBalls);
        System.Console.WriteLine($"The gumball machine was just refilled; its new count is: {this.CountOfGumballs}");

    }

    internal void ReleaseBall()
    {
        if (this.CountOfGumballs > 0)
        {
            this.CountOfGumballs--;
            System.Console.WriteLine("A gumball comes rolling out the slot...");
        }
    }

    public override string ToString()
    {
        StringBuilder result = new();

        result.AppendLine();
        result.AppendLine("Mighty Gumball, Inc.");
        result.AppendLine("Standing Gumball Model #2024");
        result.AppendLine($"Inventory: {this.CountOfGumballs} gumball(s)");
        result.AppendLine($"Machine is {this.State}");
        result.AppendLine();

        return result.ToString();
    }
}