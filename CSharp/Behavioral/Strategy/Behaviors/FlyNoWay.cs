using Strategy.Behaviors.Interfaces;

namespace Strategy.Behaviors;

internal class FlyNoWay : IFlyBehavior
{
    public string Fly()
    {
        return "I can't fly!";
    }
}
