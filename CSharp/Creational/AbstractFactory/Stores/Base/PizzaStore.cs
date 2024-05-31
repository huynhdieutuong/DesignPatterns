using AbstractFactory.Pizzas.Base;

namespace AbstractFactory.Stores.Base;
internal abstract class PizzaStore
{
    public Pizza OrderPizza(Types type)
    {
        Pizza pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

    protected abstract Pizza CreatePizza(Types type);
}
