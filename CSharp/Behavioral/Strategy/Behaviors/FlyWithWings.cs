using Strategy.Behaviors.Interfaces;

namespace Strategy.Behaviors;

internal class FlyWithWings : IFlyBehavior
{
    public string Fly()
    {
        return "I'm flying!!";
    }
}
