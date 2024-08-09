namespace CommandPattern;

public class StereoOnDefault : ICommand
{
    readonly Stereo stereo;

    public StereoOnDefault(Stereo stereo)
    {
        this.stereo = stereo;
    }

    public void Execute()
    {
        StereoOnWithRadio stereoOnWithRadio = new(this.stereo);
        stereoOnWithRadio.Execute();
    }

    public void Undo()
    {
        StereoOffCommand stereoOff = new(this.stereo);
        stereoOff.Execute();
    }
}
