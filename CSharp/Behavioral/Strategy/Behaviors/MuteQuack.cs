using Strategy.Behaviors.Interfaces;

namespace Strategy.Behaviors;

internal class MuteQuack : IQuackBehavior
{
    public string Quack()
    {
        return "<< Silence >>";
    }
}
