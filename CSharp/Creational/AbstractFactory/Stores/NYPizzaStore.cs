using AbstractFactory.Ingredients.Base;
using AbstractFactory.Pizzas;
using AbstractFactory.Pizzas.Base;
using AbstractFactory.Stores.Base;

namespace AbstractFactory.Stores;
internal class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(Types type)
    {
        Pizza? pizza = null;
        IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

        switch (type)
        {
            case Types.Cheese:
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("New York Style Cheese Pizza");
                break;
            case Types.Veggie:
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("New York Style Veggie Pizza");
                break;
            case Types.Clam:
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("New York Style Clam Pizza");
                break;
            case Types.Pepperoni:
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("New York Style Pepperoni Pizza");
                break;
        }

        return pizza;
    }
}
