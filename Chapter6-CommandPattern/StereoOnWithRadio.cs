namespace CommandPattern;

public class StereoOnWithRadio : ICommand
{
    readonly Stereo stereo;

    public StereoOnWithRadio(Stereo stereo)
    {
        this.stereo = stereo;
    }

    public void Execute()
    {
        stereo.On();
        stereo.SetRadio();
        stereo.SetVolume();
    }

    public void Undo()
    {
        StereoOffCommand stereoOff = new(this.stereo);
        stereoOff.Execute();
    }
}
