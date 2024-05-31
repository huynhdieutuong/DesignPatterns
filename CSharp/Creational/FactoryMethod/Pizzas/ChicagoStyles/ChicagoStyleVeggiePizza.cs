using FactoryMethod.Pizzas.Base;

namespace FactoryMethod.Pizzas.ChicagoStyles;
internal class ChicagoStyleVeggiePizza : Pizza
{
    public ChicagoStyleVeggiePizza()
    {
        Name = "Chicago Style Deep Dish Veggie Pizza";
        Dough = "Extra Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";
        Toppings.Add("Shredded Mozzarella Veggie");
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting the pizza into square slices");
    }
}
