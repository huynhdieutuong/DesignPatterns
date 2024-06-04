using TemplateMethod.Base;

namespace TemplateMethod;
internal class Coffee : CaffeineBeverage
{
    internal override void Brew()
    {
        Console.WriteLine("Dripping Coffee through filter");
    }

    internal override void AddCondiments()
    {
        Console.WriteLine("Adding Sugar and Milk");
    }

    internal override bool CustomerWantsCondiments()
    {
        return false;
    }
}
