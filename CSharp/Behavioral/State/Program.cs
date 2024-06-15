using State.Base;

GumballMachine gumballMachine = new(5);

Console.WriteLine(gumballMachine);

gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();

Console.WriteLine(gumballMachine);

gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();
gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();

Console.WriteLine(gumballMachine);

gumballMachine.Refill(5);

Console.WriteLine(gumballMachine);