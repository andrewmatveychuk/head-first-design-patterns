namespace CommandPattern;

public class CeilingFanOffCommand : ICommand
{
    readonly CeilingFan fan;
    CeilingFanSpeed previousSpeed;

    public CeilingFanOffCommand(CeilingFan fan)
    {
        this.fan = fan;
    }

    public void Execute()
    {
        this.previousSpeed = this.fan.speed;
        this.fan.speed = CeilingFanSpeed.Off;
        System.Console.WriteLine($"The ceiling fan is OFF.");

    }

    public void Undo()
    {
        this.fan.speed = this.previousSpeed;
        System.Console.WriteLine($"The ceiling fan is ON. Speed is {this.fan.speed}");
    }
}
