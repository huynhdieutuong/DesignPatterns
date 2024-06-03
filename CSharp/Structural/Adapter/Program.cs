using Adapter.Base;
using Adapter.Ducks;
using Adapter.Turkeys;

MallardDuck duck = new();
WildTurkey turkey = new();

IDuck turkeyAdapter = new TurkeyAdapter(turkey);

Console.WriteLine("The Turkey says...");
turkey.Gobble();
turkey.Fly();

Console.WriteLine("The Duck says...");
TestDuck(duck);

Console.WriteLine("The TurketAdapter says...");
TestDuck(turkeyAdapter);

void TestDuck(IDuck duck)
{
    duck.Quack();
    duck.Fly();
}