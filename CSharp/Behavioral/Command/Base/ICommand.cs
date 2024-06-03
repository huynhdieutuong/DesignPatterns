namespace Command.Base;
internal interface ICommand
{
    void Execute();
    void Undo();
}
