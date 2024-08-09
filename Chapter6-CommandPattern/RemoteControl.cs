using System.Text;

namespace CommandPattern;

public class RemoteControl
{
    ICommand[] onCommands;
    ICommand[] offCommands;

    ICommand undoCommand;

    private readonly int numberOfSlots;

    public int NumberOfSlots { get => numberOfSlots; }

    public RemoteControl(int numberOfSlots)
    {
        this.numberOfSlots = numberOfSlots;
        this.onCommands = new ICommand[this.numberOfSlots];
        this.offCommands = new ICommand[this.numberOfSlots];

        ICommand noCommand = new NoCommand();

        for (int i = 0; i < this.numberOfSlots; i++)
        {
            this.onCommands[i] = noCommand;
            this.offCommands[i] = noCommand;
        }
        this.undoCommand = noCommand;
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        this.onCommands[slot] = onCommand;
        this.offCommands[slot] = offCommand;
    }

    public void PressOnButton(int slot)
    {
        this.onCommands[slot].Execute();
        this.undoCommand = this.onCommands[slot];
    }
    public void PressOffButton(int slot)
    {
        this.offCommands[slot].Execute();
        this.undoCommand = this.offCommands[slot];
    }

    public void PressUndoButton()
    {
        this.undoCommand.Undo();
        this.undoCommand = new NoCommand();
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();
        stringBuilder.AppendLine("======== Remote Control ========");

        for (int i = 0; i < onCommands.Length; i++)
        {
            stringBuilder.AppendLine($"[slot {i}] {this.onCommands[i].GetType().Name} {this.offCommands[i].GetType().Name}");
        }

        stringBuilder.AppendLine("======== Undo command ========");
        stringBuilder.AppendLine($"{this.undoCommand.GetType().Name}");

        return stringBuilder.ToString();
    }
}
