using Strategy.Behaviors;
using Strategy.Behaviors.Interfaces;

namespace Strategy.Ducks;

internal abstract class Duck
{
    protected IFlyBehavior FlyBehavior { get; set; } = new FlyNoWay();
    protected IQuackBehavior QuackBehavior { get; set; } = new MuteQuack();

    internal abstract void Display();

    internal void Swim()
    {
        Console.WriteLine("All ducks can swim");
    }

    internal void PerformFly()
    {
        Console.WriteLine(FlyBehavior.Fly());
    }

    internal void PerformQuack()
    {
        Console.WriteLine(QuackBehavior.Quack());
    }

    internal void SetFlyBehavior(IFlyBehavior flyBehavior)
    {
        FlyBehavior = flyBehavior;
    }

    internal void SetQuackBehavior(IQuackBehavior quackBehavior)
    {
        QuackBehavior = quackBehavior;
    }
}
