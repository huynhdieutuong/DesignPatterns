using FactoryMethod.Pizzas.Base;

namespace FactoryMethod.Pizzas.NYStyles;
internal class NYStyleClamPizza : Pizza
{
    public NYStyleClamPizza()
    {
        Name = "NY Style Clam Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";
        Toppings.Add("Grated Reggiano Clam");
    }
}
