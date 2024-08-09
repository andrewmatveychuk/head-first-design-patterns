namespace CommandPattern;

public class GarageDoor
{
    public void Up()
    {
        System.Console.WriteLine("Opening the garage door...");
    }
    public void Down()
    {
        System.Console.WriteLine("Closing the garage door...");
    }
    public void Stop()
    {
        System.Console.WriteLine("Stopped the door.");
    }
    public void LightOn()
    {
        System.Console.WriteLine("Garage lights are ON.");
    }
    public void LightOff()
    {
        System.Console.WriteLine("Garage lights are OFF.");
    }
}
