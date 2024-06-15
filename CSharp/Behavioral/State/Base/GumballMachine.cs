using State.States;
using System.Text;

namespace State.Base;
internal class GumballMachine
{
    readonly IState _soldOutState;
    readonly IState _noQuarterState;
    readonly IState _hasQuarterState;
    readonly IState _soldState;
    readonly IState _winnerState;

    private IState _state;
    private int _count = 0;

    public GumballMachine(int numberGumballs)
    {
        _soldOutState = new SoldOutState(this);
        _noQuarterState = new NoQuarterState(this);
        _hasQuarterState = new HasQuarterState(this);
        _soldState = new SoldState(this);
        _winnerState = new WinnerState(this);

        _state = _soldOutState;
        _count = numberGumballs;

        if (numberGumballs > 0) _state = _noQuarterState;
    }

    public void InsertQuarter()
    {
        _state.InsertQuarter();
    }

    public void EjectQuarter()
    {
        _state.EjectQuarter();
    }

    public void TurnCrank()
    {
        _state.TurnCrank();
        _state.Dispense();
    }

    public void SetState(IState state)
    {
        _state = state;
    }

    public void ReleaseBall()
    {
        Console.WriteLine("A gumball comes rolling out the slot...");
        if (_count != 0) _count--;
    }

    public void Refill(int count)
    {
        _count = count;
        _state = _noQuarterState;
    }

    public IState GetSoldOutState() => _soldOutState;
    public IState GetNoQuarterState() => _noQuarterState;
    public IState GetHasQuarterState() => _hasQuarterState;
    public IState GetSoldState() => _soldState;
    public IState GetWinnerState() => _winnerState;
    public int GetCount() => _count;

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.Append("\nMight Gumball, Inc\n");
        sb.Append($"Inventory: {_count} gumballs\n");
        sb.Append("Machine is waiting for quarter\n");
        return sb.ToString();
    }
}
