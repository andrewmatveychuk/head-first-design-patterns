namespace GumballMachineWithState;

public interface IGumballMachineState
{
    public void InsertQuarter();
    public void EjectQuarter();
    public void TurnCrank();
    public void Dispense();
    public void Refill(int numberOfGumBalls);
}
