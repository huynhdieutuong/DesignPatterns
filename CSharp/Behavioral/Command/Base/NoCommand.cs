namespace Command.Base;
internal class NoCommand : ICommand
{
    public void Execute()
    {
        throw new NotImplementedException();
    }

    public void Undo()
    {
        throw new NotImplementedException();
    }
}
