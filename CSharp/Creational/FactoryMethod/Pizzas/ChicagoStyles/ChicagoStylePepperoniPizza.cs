using FactoryMethod.Pizzas.Base;

namespace FactoryMethod.Pizzas.ChicagoStyles;
internal class ChicagoStylePepperoniPizza : Pizza
{
    public ChicagoStylePepperoniPizza()
    {
        Name = "Chicago Style Deep Dish Pepperoni Pizza";
        Dough = "Extra Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";
        Toppings.Add("Shredded Mozzarella Pepperoni");
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting the pizza into square slices");
    }
}
