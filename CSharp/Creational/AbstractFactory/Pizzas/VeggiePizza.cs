using AbstractFactory.Ingredients.Base;
using AbstractFactory.Pizzas.Base;

namespace AbstractFactory.Pizzas;
internal class VeggiePizza : Pizza
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
        Veggies = _ingredientFactory.CreateVeggies();
    }
}
