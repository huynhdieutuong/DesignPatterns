namespace TemplateMethod.Base;
internal abstract class CaffeineBeverage
{
    internal void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();
        if (CustomerWantsCondiments())
        {
            AddCondiments();
        }
    }

    internal abstract void Brew();

    internal abstract void AddCondiments();

    void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    void PourInCup()
    {
        Console.WriteLine("Pouring into cup");
    }

    // Hooks
    internal virtual bool CustomerWantsCondiments()
    {
        return true;
    }
}
