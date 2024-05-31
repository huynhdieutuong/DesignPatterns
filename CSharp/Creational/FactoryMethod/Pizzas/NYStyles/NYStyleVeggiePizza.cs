using FactoryMethod.Pizzas.Base;

namespace FactoryMethod.Pizzas.NYStyles;
internal class NYStyleVeggiePizza : Pizza
{
    public NYStyleVeggiePizza()
    {
        Name = "NY Style Veggie Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";
        Toppings.Add("Grated Reggiano Veggie");
    }
}
