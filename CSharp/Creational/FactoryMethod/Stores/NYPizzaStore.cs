using FactoryMethod.Pizzas.Base;
using FactoryMethod.Pizzas.NYStyles;
using FactoryMethod.Stores.Base;

namespace FactoryMethod.Stores;
internal class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(Types type)
    {
        return type switch
        {
            Types.Cheese => new NYStyleCheesePizza(),
            Types.Veggie => new NYStyleVeggiePizza(),
            Types.Clam => new NYStyleClamPizza(),
            Types.Pepperoni => new NYStylePepperoniPizza(),
            _ => throw new NotImplementedException()
        };
    }
}
