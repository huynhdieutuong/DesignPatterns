namespace Decorator.Base;
internal abstract class CondimentDecorator : Beverage
{
    private readonly Beverage _beverage;

    protected CondimentDecorator(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override double Cost()
    {
        return _beverage.Cost();
    }

    public abstract double GetCostBySize();
}
