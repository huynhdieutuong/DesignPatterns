namespace Iterator.Menus;
internal class MenuItem
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

    public string GetName() => Name;
    public string GetDescription() => Description;
    public bool GetVegetarian() => Vegetarian;
    public double GetPrice() => Price;
}
