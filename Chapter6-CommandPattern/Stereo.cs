namespace CommandPattern;

public class Stereo
{
    public void On()
    {
        System.Console.WriteLine("The stereo is ON.");
    }
    public void Off()
    {
        System.Console.WriteLine("The stereo is OFF.");
    }
    public void SetCd()
    {
        System.Console.WriteLine("Loading a CD...");
    }
    public void SetDvd()
    {
        System.Console.WriteLine("Loading a DVD...");
    }
    public void SetRadio()
    {
        System.Console.WriteLine("Tuning the radio...");
    }
    public void SetVolume()
    {
        System.Console.WriteLine("Adjusting the volume...");
    }
}
