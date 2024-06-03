using System.Text;

namespace Command.Base;
internal class RemoteControl
{
    private const int Slots = 7;
    private readonly ICommand[] _onCommands;
    private readonly ICommand[] _offCommands;
    private ICommand _undoCommand;

    public RemoteControl()
    {
        _onCommands = new ICommand[Slots];
        _offCommands = new ICommand[Slots];

        ICommand noCommand = new NoCommand();
        for (int i = 0; i < Slots; i++)
        {
            _onCommands[i] = noCommand;
            _offCommands[i] = noCommand;
        }
        _undoCommand = noCommand;
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        _onCommands[slot] = onCommand;
        _offCommands[slot] = offCommand;
    }

    public void OnButtonWasPushed(int slot)
    {
        _onCommands[slot]?.Execute();
        _undoCommand = _onCommands[slot];
    }

    public void OffButtonWasPushed(int slot)
    {
        _offCommands[slot]?.Execute();
        _undoCommand = _offCommands[slot];
    }

    public void UndoButtonWasPushed()
    {
        _undoCommand?.Undo();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("\n------ Remote Control -------\n");
        for (int i = 0; i < Slots; i++)
        {
            sb.Append($"[slot {i}] {_onCommands[i].GetType().Name}   {_offCommands[i].GetType().Name}\n");
        }
        sb.Append($"[undo] {_undoCommand.GetType().Name}\n");
        return sb.ToString();
    }
}
