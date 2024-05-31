using FactoryMethod.Pizzas.Base;

namespace FactoryMethod.Pizzas.NYStyles;
internal class NYStylePepperoniPizza : Pizza
{
    public NYStylePepperoniPizza()
    {
        Name = "NY Style Pepperoni Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";
        Toppings.Add("Grated Reggiano Pepperoni");
    }
}
