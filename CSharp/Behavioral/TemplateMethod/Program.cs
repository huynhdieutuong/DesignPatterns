using TemplateMethod;

Console.WriteLine("\nMaking tea...");
Tea myTea = new();
myTea.PrepareRecipe();

Console.WriteLine("\nMaking coffee...");
Coffee myCoffee = new();
myCoffee.PrepareRecipe();