using State.Base;

namespace State.States;
internal class SoldOutState : IState
{
    private GumballMachine _gumballMachine;

    public SoldOutState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("The machine is sold out");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You haven’t inserted a quarter yet");
    }

    public void TurnCrank()
    {
        Console.WriteLine("There are no gumballs");
    }

    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed");
    }
}
