using FactoryMethod.Pizzas.Base;
using FactoryMethod.Stores;
using FactoryMethod.Stores.Base;

PizzaStore nyStore = new NYPizzaStore();
PizzaStore chicagoStore = new ChicagoPizzaStore();

Pizza pizza = nyStore.OrderPizza(Types.Cheese);
Console.WriteLine($"Ethan ordered a {pizza.GetName()}");

Console.WriteLine("==========");

pizza = chicagoStore.OrderPizza(Types.Cheese);
Console.WriteLine($"Joel ordered a {pizza.GetName()}");