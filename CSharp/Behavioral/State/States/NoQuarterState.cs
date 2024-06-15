using State.Base;

namespace State.States;
internal class NoQuarterState : IState
{
    private GumballMachine _gumballMachine;

    public NoQuarterState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You inserted a quarter");
        _gumballMachine.SetState(_gumballMachine.GetHasQuarterState());
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You haven’t inserted a quarter"); ;
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned, but there’s no quarter");
    }

    public void Dispense()
    {
        Console.WriteLine("You need to pay first");
    }
}
