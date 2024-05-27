using Strategy.Behaviors.Interfaces;

namespace Strategy.Behaviors;

internal class FlyRocketPowered : IFlyBehavior
{
    public string Fly()
    {
        return "I'm flying with a rocket!";
    }
}
