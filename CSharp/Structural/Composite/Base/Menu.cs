namespace Composite.Base;
internal class Menu : MenuComponent
{
    List<MenuComponent> MenuComponents = [];
    string Name;
    string Description;

    public Menu(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public override void Add(MenuComponent menuComponent)
    {
        MenuComponents.Add(menuComponent);
    }

    public override void Remove(MenuComponent menuComponent)
    {
        MenuComponents.Remove(menuComponent);
    }

    public override MenuComponent GetChild(int i)
    {
        return MenuComponents[i];
    }

    public override string GetName()
    {
        return Name;
    }

    public override string GetDescription()
    {
        return Description;
    }

    public override void Print()
    {
        Console.WriteLine($"\n {GetName()}, {GetDescription()}");
        Console.WriteLine("---------------------");

        MenuComponents.ForEach(menuComponent => menuComponent.Print());
    }
}
