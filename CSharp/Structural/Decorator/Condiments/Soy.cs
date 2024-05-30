using Decorator.Base;

namespace Decorator.Condiments;
internal class Soy : CondimentDecorator
{
    public Soy(Beverage beverage) : base(beverage)
    {
        Description = beverage.GetDescription() + ", Soy";
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
            Sizes.TALL => .10,
            Sizes.GRANDE => .15,
            Sizes.VENTI => .20,
            _ => throw new NotImplementedException()
        };
    }
}
