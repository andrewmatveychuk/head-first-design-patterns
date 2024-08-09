namespace CommandPattern;

public class StereoOffCommand : ICommand
{
    Stereo stereo;

    public StereoOffCommand(Stereo stereo)
    {
        this.stereo = stereo;
    }

    public void Execute()
    {
        stereo.Off();
    }

    public void Undo()
    {
        StereoOnDefault stereoOnDefault = new(this.stereo);
        stereoOnDefault.Execute();
    }
}
