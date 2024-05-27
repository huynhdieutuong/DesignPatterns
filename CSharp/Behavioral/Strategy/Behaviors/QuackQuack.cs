using Strategy.Behaviors.Interfaces;

namespace Strategy.Behaviors;

internal class QuackQuack : IQuackBehavior
{
    public string Quack()
    {
        return "Quack Quack";
    }
}
