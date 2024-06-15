using State.Base;

namespace State.States;
internal class WinnerState : IState
{
    private GumballMachine _gumballMachine;

    public WinnerState(GumballMachine gumballMachine)
    {
        _gumballMachine = gumballMachine;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("Please wait, we’re already giving you a gumball");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Sorry, you already turned the crank");
    }

    public void TurnCrank()
    {
        Console.WriteLine("Turning twice doesn’t get you another gumball!");
    }

    public void Dispense()
    {
        Console.WriteLine("YOU’RE A WINNER! You get two gumballs for your quarter");
        _gumballMachine.ReleaseBall();
        if (_gumballMachine.GetCount() == 0)
        {
            _gumballMachine.SetState(_gumballMachine.GetSoldOutState());
        }
        else
        {
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.GetCount() > 0)
            {
                _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                _gumballMachine.SetState(_gumballMachine.GetSoldOutState());
            }
        }
    }
}
