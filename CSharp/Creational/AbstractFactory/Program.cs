using AbstractFactory.Pizzas.Base;
using AbstractFactory.Stores;
using AbstractFactory.Stores.Base;

PizzaStore nyStore = new NYPizzaStore();
PizzaStore chicagoStore = new ChicagoPizzaStore();

Pizza pizza = nyStore.OrderPizza(Types.Veggie);
Console.WriteLine($"Ethan ordered a {pizza.GetName()}");

Console.WriteLine("==========");

pizza = chicagoStore.OrderPizza(Types.Pepperoni);
Console.WriteLine($"Joel ordered a {pizza.GetName()}");