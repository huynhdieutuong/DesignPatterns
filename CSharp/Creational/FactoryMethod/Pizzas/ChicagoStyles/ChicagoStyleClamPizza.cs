using FactoryMethod.Pizzas.Base;

namespace FactoryMethod.Pizzas.ChicagoStyles;
internal class ChicagoStyleClamPizza : Pizza
{
    public ChicagoStyleClamPizza()
    {
        Name = "Chicago Style Deep Dish Clam Pizza";
        Dough = "Extra Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";
        Toppings.Add("Shredded Mozzarella Clam");
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting the pizza into square slices");
    }
}
