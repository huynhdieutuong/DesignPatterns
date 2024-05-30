using Decorator.Base;

namespace Decorator.Beverages;
internal class Decaf : Beverage
{
    public Decaf(Sizes size)
    {
        Description = "Decaf";
        Size = size;
    }

    public override double Cost()
    {
        return 1.05;
    }
}
