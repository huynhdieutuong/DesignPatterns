namespace Command.Base;
internal class MacroCommand : ICommand
{
    ICommand[] Commands;

    public MacroCommand(ICommand[] commands)
    {
        Commands = commands;
    }

    public void Execute()
    {
        Commands.ToList().ForEach(c => c.Execute());
    }

    public void Undo()
    {
        Commands.ToList().ForEach(c => c.Undo());
    }
}
