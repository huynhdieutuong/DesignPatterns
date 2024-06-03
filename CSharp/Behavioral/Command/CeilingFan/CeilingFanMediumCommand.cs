using Command.Base;

namespace Command.CeilingFan;
internal class CeilingFanMediumCommand : ICommand
{
    private readonly CeilingFan _ceilingFan;
    int PrevSpeed;

    public CeilingFanMediumCommand(CeilingFan ceilingFan)
    {
        _ceilingFan = ceilingFan;
    }

    public void Execute()
    {
        PrevSpeed = _ceilingFan.GetSpeed();
        _ceilingFan.Medium();
    }

    public void Undo()
    {
        CeilingFanHelpers.Undo(PrevSpeed, _ceilingFan);
    }
}
