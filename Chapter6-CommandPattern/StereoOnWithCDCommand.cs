namespace CommandPattern;

public class StereoOnWithCDCommand : ICommand
{
    readonly Stereo stereo;

    public StereoOnWithCDCommand(Stereo stereo)
    {
        this.stereo = stereo;
    }

    public void Execute()
    {
        stereo.On();
        stereo.SetCd();
        stereo.SetVolume();
    }

    public void Undo()
    {
        StereoOffCommand stereoOff = new(this.stereo);
        stereoOff.Execute();
    }
}
