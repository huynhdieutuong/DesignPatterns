namespace Composite.Base;
internal class MenuItem : MenuComponent
{
    string Name;
    string Description;
    bool Vegetarian;
    double Price;

    public MenuItem(string name, string description, bool vegetarian, double price)
    {
        Name = name;
        Description = description;
        Vegetarian = vegetarian;
        Price = price;
    }

    public override string GetName()
    {
        return Name;
    }

    public override string GetDescription()
    {
        return Description;
    }

    public override double GetPrice()
    {
        return Price;
    }

    public override bool IsVegetarian()
    {
        return Vegetarian;
    }

    public override void Print()
    {
        string vegetarian = IsVegetarian() ? "(v)" : "";
        Console.WriteLine($" {GetName()}{vegetarian}, {GetPrice()} -- {GetDescription()}");
    }
}
