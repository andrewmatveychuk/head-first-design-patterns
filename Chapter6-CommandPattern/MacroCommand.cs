namespace CommandPattern;

public class MacroCommand : ICommand
{
    readonly ICommand[] commands;

    public MacroCommand(ICommand[] commands)
    {
        this.commands = commands;
    }

    public void Execute()
    {
        foreach (var command in this.commands) command.Execute();
    }

    public void Undo()
    {
        foreach (var command in this.commands) command.Undo();
    }
}
