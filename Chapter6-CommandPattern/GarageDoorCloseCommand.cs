namespace CommandPattern;

public class GarageDoorCloseCommand : ICommand
{
    readonly GarageDoor garageDoor;

    public GarageDoorCloseCommand(GarageDoor garageDoor)
    {
        this.garageDoor = garageDoor;
    }
    public void Execute()
    {
        this.garageDoor.Down();
        this.garageDoor.LightOff();
        System.Console.WriteLine("The garage door is CLOSED.");
    }

    public void Undo()
    {
        GarageDoorOpenCommand garageDoorOpen = new(this.garageDoor);
        garageDoorOpen.Execute();
    }
}
