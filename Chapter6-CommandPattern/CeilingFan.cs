namespace CommandPattern;

public class CeilingFan
{
    public string Location { get; }
    public CeilingFanSpeed speed;

    public CeilingFan(string location)
    {
        this.Location = location;
        this.speed = CeilingFanSpeed.Off;
    }

    public void Off()
    {
        System.Console.WriteLine("The ceiling fan is OFF.");
        this.speed = CeilingFanSpeed.Off;
    }

    public void On()
    {
        this.speed = CeilingFanSpeed.Low;
        System.Console.WriteLine($"The ceiling fan is ON. Speed is {this.speed}");
    }
}

public enum CeilingFanSpeed
{
    Off = 0,
    Low = 1,
    Medium = 2,
    High = 3
}