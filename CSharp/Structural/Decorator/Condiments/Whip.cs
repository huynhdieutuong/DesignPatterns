using Decorator.Base;

namespace Decorator.Condiments;
internal class Whip : CondimentDecorator
{
    public Whip(Beverage beverage) : base(beverage)
    {
        Description = beverage.GetDescription() + ", Whip";
        Size = beverage.GetSize();
    }

    public override double Cost()
    {
        return GetCostBySize() + base.Cost();
    }

    public override double GetCostBySize()
    {
        return GetSize() switch
        {
            Sizes.TALL => .05,
            Sizes.GRANDE => .10,
            Sizes.VENTI => .15,
            _ => throw new NotImplementedException()
        };
    }
}
