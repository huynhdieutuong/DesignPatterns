using Command.Base;

namespace Command.CeilingFan;
internal class CeilingFanHighCommand : ICommand
{
    private readonly CeilingFan _ceilingFan;
    int PrevSpeed;

    public CeilingFanHighCommand(CeilingFan ceilingFan)
    {
        _ceilingFan = ceilingFan;
    }

    public void Execute()
    {
        PrevSpeed = _ceilingFan.GetSpeed();
        _ceilingFan.High();
    }

    public void Undo()
    {
        CeilingFanHelpers.Undo(PrevSpeed, _ceilingFan);
    }
}
