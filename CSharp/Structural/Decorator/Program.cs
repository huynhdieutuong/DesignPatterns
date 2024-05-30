using Decorator.Base;
using Decorator.Beverages;
using Decorator.Condiments;

Beverage beverage = new Espresso(Sizes.TALL);
Console.WriteLine($"{beverage.GetDescription()} ({beverage.GetSize()}) ${beverage.Cost()}");

Beverage beverage2 = new DarkRoast(Sizes.GRANDE);
beverage2 = new Mocha(beverage2);
beverage2 = new Mocha(beverage2);
beverage2 = new Whip(beverage2);
Console.WriteLine($"{beverage2.GetDescription()} ({beverage2.GetSize()}) ${beverage2.Cost()}");

Beverage beverage3 = new HouseBlend(Sizes.VENTI);
beverage3 = new Soy(beverage3);
beverage3 = new Mocha(beverage3);
beverage3 = new Whip(beverage3);
Console.WriteLine($"{beverage3.GetDescription()} ({beverage3.GetSize()}) ${beverage3.Cost()}");