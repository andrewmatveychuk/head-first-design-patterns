namespace CommandPattern;

public class NoCommand : ICommand
{
    public void Execute()
    {
        System.Console.WriteLine("No command set.");
    }

    public void Undo()
    {
        this.Execute();
    }
}
