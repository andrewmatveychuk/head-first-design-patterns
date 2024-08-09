namespace CommandPattern;

public class SimpleRemoteControl
{
    ICommand? _slot;

    public SimpleRemoteControl() { }

    public void SetCommand(ICommand command) { _slot = command; }

    public void PressTheButton()
    {
        if (_slot is not null)
        {
            _slot.Execute();
        }
        else
        {
            System.Console.WriteLine("ERROR: The device is not set.");
        }
    }
}
