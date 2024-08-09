namespace CommandPattern;

public class CeilingFanHighCommand : ICommand
{
    readonly CeilingFan fan;
    CeilingFanSpeed previousSpeed;

    public CeilingFanHighCommand(CeilingFan fan)
    {
        this.fan = fan;
    }

    public void Execute()
    {
        this.previousSpeed = this.fan.speed;
        this.fan.speed = CeilingFanSpeed.High;
        System.Console.WriteLine($"The ceiling fan is ON. Speed is {this.fan.speed}");
    }

    public void Undo()
    {
        this.fan.speed = this.previousSpeed;
        System.Console.WriteLine($"The ceiling speed is {this.fan.speed}");
    }
}
