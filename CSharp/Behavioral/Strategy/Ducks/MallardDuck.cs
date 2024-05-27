using Strategy.Behaviors;

namespace Strategy.Ducks;

internal class MallardDuck : Duck
{
    internal MallardDuck()
    {
        FlyBehavior = new FlyWithWings();
        QuackBehavior = new QuackQuack();
    }

    internal override void Display()
    {
        Console.WriteLine("I'm a real Mallard duck");
    }
}
