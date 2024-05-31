using FactoryMethod.Pizzas.Base;

namespace FactoryMethod.Pizzas.NYStyles;
internal class NYStyleCheesePizza : Pizza
{
    public NYStyleCheesePizza()
    {
        Name = "NY Style Sauce and Cheese Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";
        Toppings.Add("Grated Reggiano Cheese");
    }
}
