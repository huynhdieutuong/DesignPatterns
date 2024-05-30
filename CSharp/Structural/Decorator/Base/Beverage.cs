namespace Decorator.Base;
internal abstract class Beverage
{
    protected string Description = "Unkown Beverage";
    protected Sizes Size = Sizes.GRANDE;

    public string GetDescription() => Description;

    public Sizes GetSize() => Size;

    public abstract double Cost();
}
