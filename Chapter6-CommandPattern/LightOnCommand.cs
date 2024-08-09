namespace CommandPattern;

public class LightOnCommand : ICommand
{
    readonly Light light;

    public LightOnCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        this.light.On();
    }

    public void Undo()
    {
        LightOffCommand lightOff = new LightOffCommand(this.light);
        lightOff.Execute();
    }
}