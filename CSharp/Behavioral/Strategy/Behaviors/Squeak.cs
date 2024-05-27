using Strategy.Behaviors.Interfaces;

namespace Strategy.Behaviors;

internal class Squeak : IQuackBehavior
{
    public string Quack()
    {
        return "Squeak";
    }
}
