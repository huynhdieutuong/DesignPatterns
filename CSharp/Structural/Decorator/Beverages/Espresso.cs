using Decorator.Base;

namespace Decorator.Beverages;
internal class Espresso : Beverage
{
    public Espresso(Sizes size)
    {
        Description = "Espresso";
        Size = size;
    }

    public override double Cost()
    {
        return 1.99;
    }
}
