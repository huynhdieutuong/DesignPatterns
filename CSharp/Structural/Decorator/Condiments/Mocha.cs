using Decorator.Base;

namespace Decorator.Condiments;
internal class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage) : base(beverage)
    {
        Description = beverage.GetDescription() + ", Mocha";
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
            Sizes.TALL => .15,
            Sizes.GRANDE => .20,
            Sizes.VENTI => .25,
            _ => throw new NotImplementedException()
        };
    }
}
