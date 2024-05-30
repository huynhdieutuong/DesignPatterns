using Decorator.Base;

namespace Decorator.Beverages;
internal class HouseBlend : Beverage
{
    public HouseBlend(Sizes size)
    {
        Description = "House Blend Coffee";
        Size = size;
    }

    public override double Cost()
    {
        return .89;
    }
}
