using TemplateMethod.Base;

namespace TemplateMethod;
internal class Tea : CaffeineBeverage
{
    internal override void Brew()
    {
        Console.WriteLine("Steeping the tea");
    }

    internal override void AddCondiments()
    {
        Console.WriteLine("Adding Lemon");
    }
}
