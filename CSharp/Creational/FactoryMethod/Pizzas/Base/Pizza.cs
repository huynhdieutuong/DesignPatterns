namespace FactoryMethod.Pizzas.Base;
internal abstract class Pizza
{
    protected string? Name;
    protected string? Dough;
    protected string? Sauce;
    protected List<string> Toppings = [];

    public void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Console.WriteLine($"Tossing dough {Dough}");
        Console.WriteLine($"Adding sauce {Sauce}");
        Console.WriteLine($"Adding toppings:");
        Toppings[0].Split(" ").ToList().ForEach(topping => Console.WriteLine($" {topping}"));
    }

    public void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }

    public string GetName() => Name ?? "No name";
}
