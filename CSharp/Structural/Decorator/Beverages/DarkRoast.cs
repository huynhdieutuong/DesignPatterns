using Decorator.Base;

namespace Decorator.Beverages;
internal class DarkRoast : Beverage
{
    public DarkRoast(Sizes size)
    {
        Description = "Dark Roast Coffee";
        Size = size;
    }

    public override double Cost()
    {
        return .99;
    }
}
