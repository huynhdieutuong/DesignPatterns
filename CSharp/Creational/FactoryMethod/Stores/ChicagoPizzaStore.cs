using FactoryMethod.Pizzas.Base;
using FactoryMethod.Pizzas.ChicagoStyles;
using FactoryMethod.Stores.Base;

namespace FactoryMethod.Stores;
internal class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(Types type)
    {
        return type switch
        {
            Types.Cheese => new ChicagoStyleCheesePizza(),
            Types.Veggie => new ChicagoStyleVeggiePizza(),
            Types.Clam => new ChicagoStyleClamPizza(),
            Types.Pepperoni => new ChicagoStylePepperoniPizza(),
            _ => throw new NotImplementedException()
        };
    }
}
