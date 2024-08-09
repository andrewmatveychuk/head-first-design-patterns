namespace CommandPattern;

public class GarageDoorOpenCommand : ICommand
{
    readonly GarageDoor garageDoor;

    public GarageDoorOpenCommand(GarageDoor garageDoor)
    {
        this.garageDoor = garageDoor;
    }
    public void Execute()
    {
        this.garageDoor.Up();
        this.garageDoor.LightOn();
        System.Console.WriteLine("The garage door is OPEN.");
    }

    public void Undo()
    {
        GarageDoorCloseCommand garageDoorClose = new(this.garageDoor);
        garageDoorClose.Execute();
    }
}
