using Command.Base;

namespace Command.GarageDoor;
internal class GarageDoorDownCommand : ICommand
{
    private readonly GarageDoor _garageDoor;

    public GarageDoorDownCommand(GarageDoor garageDoor)
    {
        _garageDoor = garageDoor;
    }

    public void Execute()
    {
        _garageDoor.Down();
    }

    public void Undo()
    {
        _garageDoor.Up();
    }
}
