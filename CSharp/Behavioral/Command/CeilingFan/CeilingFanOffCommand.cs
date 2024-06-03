using Command.Base;

namespace Command.CeilingFan;
internal class CeilingFanOffCommand : ICommand
{
    private readonly CeilingFan _ceilingFan;
    int PrevSpeed;

    public CeilingFanOffCommand(CeilingFan ceilingFan)
    {
        _ceilingFan = ceilingFan;
    }

    public void Execute()
    {
        PrevSpeed = _ceilingFan.GetSpeed();
        _ceilingFan.Off();
    }

    public void Undo()
    {
        CeilingFanHelpers.Undo(PrevSpeed, _ceilingFan);
    }
}
