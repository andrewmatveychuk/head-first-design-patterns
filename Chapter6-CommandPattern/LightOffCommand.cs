namespace CommandPattern;

public class LightOffCommand : ICommand
{
    readonly Light light;

    public LightOffCommand(Light light) {
        this.light = light;
    }

    public void Execute()
    {
        this.light.Off();
    }

    public void Undo()
    {
        LightOnCommand lightOn = new(this.light);
        lightOn.Execute();
    }
}
