using AbstractFactory.Ingredients;

namespace AbstractFactory.Pizzas.Base;
internal abstract class Pizza
{
    protected string Name;
    protected Dough Dough;
    protected Sauce Sauce;
    protected List<Veggie> Veggies;
    protected Cheese Cheese;
    protected Pepperoni Pepperoni;
    protected Clam Clam;

    public abstract void Prepare();

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

    public void SetName(string name) { Name = name; }
}
